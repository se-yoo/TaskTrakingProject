using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTrakingProject
{
    public partial class ItemRetrieve : Form
    {
        UserHome userHome;
        AdminHome adminHome;
        Task task;
        Member member;
        List<TaskHistory> taskHistoryList= new List<TaskHistory>();

        public ItemRetrieve()
        {
            InitializeComponent();
        }

        public ItemRetrieve(UserHome userHome, Task task, Member member)
        {
            InitializeComponent();

            this.userHome = userHome;
            this.task = task;
            this.member = member;
        }

        public ItemRetrieve(AdminHome adminHome, Task task, Member member)
        {
            InitializeComponent();

            this.adminHome = adminHome;
            this.task = task;
            this.member = member;
        }

        private void LoadTaskInfo()
        {
            using (MySqlConnection con = new MySqlConnection(Database.getConnection()))
            {
                MySqlCommand com = con.CreateCommand();

                try
                {
                    con.Open();

                    string sql = @"SELECT *, (SELECT name FROM member WHERE id=t.rgstMemId) as rgstMemName, (SELECT name FROM member WHERE id=t.chargeMemId) as chargeMemName "
                                                + "FROM task t WHERE seq='" + task.seq + "'";

                    com.CommandText = sql;
                    MySqlDataReader reader = com.ExecuteReader();

                    reader.Read();
                    
                    task.seq = System.Convert.ToInt32(reader["seq"]);
                    task.title = reader["title"].ToString();
                    task.content = reader["content"].ToString();
                    task.rgstMemId = reader["rgstMemId"].ToString();
                    task.rgstMemName = reader["rgstMemName"].ToString();
                    task.chargeMemId = reader["chargeMemId"].ToString();
                    task.chargeMemName = reader["chargeMemName"].ToString();
                    task.status = System.Convert.ToInt32(reader["status"]);
                    task.rgstDate = reader["rgstDate"].ToString();

                }
                catch
                {
                    MessageBox.Show("데이터베이스 연결오류");
                }
                con.Close();
            }
        }

        private void LoadTaskHistorys()
        {
            using (MySqlConnection con = new MySqlConnection(Database.getConnection()))
            {
                MySqlCommand com = con.CreateCommand();

                try
                {
                    con.Open();

                    string sql = @"SELECT * FROM task_history " +
                                                "WHERE taskSeq='" + task.seq + "' " +
                                                "ORDER BY seq DESC";

                    com.CommandText = sql;
                    MySqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        TaskHistory taskHistory = new TaskHistory();
                        taskHistory.seq = System.Convert.ToInt32(reader["seq"]);
                        taskHistory.content = reader["content"].ToString();
                        taskHistory.rgstDate = reader["rgstDate"].ToString();

                        AddListViewTaskHistoryItem(taskHistory);
                    }

                }
                catch
                {
                    MessageBox.Show("데이터베이스 연결오류");
                }
                con.Close();
            }
        }

        private void AddListViewTaskHistoryItem(TaskHistory th)
        {
            ListViewItem item = new ListViewItem(th.content);
            item.SubItems.Add(th.rgstDate);

            historyList.Items.Add(item);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            if (member.auth == 0)
            {
                userHome.Location = new Point(this.Location.X, this.Location.Y);
                userHome.Show();
            }
            else
            {
                adminHome.Location = new Point(this.Location.X, this.Location.Y);
                adminHome.Show();
            }
        }

        private void ItemRetrieve_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            if (member.auth == 0)
            {
                userHome.Location = new Point(this.Location.X, this.Location.Y);
                userHome.Show();
            }
            else
            {
                adminHome.Location = new Point(this.Location.X, this.Location.Y);
                adminHome.Show();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("문의를 삭제하시겠습니까?","문의 삭제",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                using (MySqlConnection con = new MySqlConnection(Database.getConnection()))
                {
                    MySqlCommand com = con.CreateCommand();

                    try
                    {
                        con.Open();

                        string sql = @"DELETE FROM task_history " +
                                                    "WHERE taskSeq=" + task.seq;

                        com.CommandText = sql;
                        com.ExecuteNonQuery();


                        sql = @"DELETE FROM task WHERE seq=" + task.seq;

                        com.CommandText = sql;
                        com.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("데이터베이스 연결오류");
                    }
                    con.Close();

                    task.seq = -1;

                    this.Close();
                    userHome.Location = new Point(this.Location.X, this.Location.Y);
                    userHome.Show();
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            ItemCreate ic = new ItemCreate(this, member, task);
            ic.Location = new Point(this.Location.X, this.Location.Y);
            ic.ShowDialog();
        }

        private void ItemRetrieve_VisibleChanged(object sender, EventArgs e)
        {
            historyList.Items.Clear();
            taskHistoryList.Clear();

            if(task.seq>0)
            {
                LoadTaskInfo();
                LoadTaskHistorys();

                addHistoryBtn.Hide();
                updateBtn.Hide();
                deleteBtn.Hide();
                startBtn.Hide();
                endBtn.Hide();

                if (member.auth == 0 && task.status == 0)
                {
                    updateBtn.Show();
                    deleteBtn.Show();
                }
                else if (member.auth == 1 && task.status == 0)
                {
                    startBtn.Show();
                }
                else if (member.auth == 1 && task.status == 1)
                {
                    addHistoryBtn.Show();
                    endBtn.Show();
                }

                titleBox.Text = task.title;
                contentBox.Text = task.content;
                rgstBox.Text = task.rgstMemName;
                if (task.chargeMemId.CompareTo("") != 0 && task.chargeMemId != null)
                {
                    chargerBox.Text = task.chargeMemName;
                }
            }
        }

        private void ItemRetrieve_Load(object sender, EventArgs e)
        {
            if(member.auth==0)
            {
                using (MySqlConnection con = new MySqlConnection(Database.getConnection()))
                {
                    MySqlCommand com = con.CreateCommand();

                    try
                    {
                        con.Open();

                        string sql = @"UPDATE task SET updateRead=0 " +
                                                    "WHERE seq=" + task.seq;

                        com.CommandText = sql;
                        com.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("데이터베이스 연결오류");
                    }
                    con.Close();
                }
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(Database.getConnection()))
            {
                MySqlCommand com = con.CreateCommand();

                try
                {
                    con.Open();

                    string sql = @"UPDATE task SET updateRead=1, status=1, chargeMemId='"+member.id+"' " +
                                                "WHERE seq=" + task.seq;

                    com.CommandText = sql;
                    com.ExecuteNonQuery();

                    sql = @"INSERT INTO task_history (taskSeq, content, rgstDate) VALUES "
                                            + "("+task.seq+", '담당자배정', NOW())";

                    com.CommandText = sql;
                    com.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("데이터베이스 연결오류");
                }
                con.Close();

                this.Close();
                adminHome.Location = new Point(this.Location.X, this.Location.Y);
                adminHome.Show();
            }
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(Database.getConnection()))
            {
                MySqlCommand com = con.CreateCommand();

                try
                {
                    con.Open();

                    string sql = @"UPDATE task SET updateRead=1, status=2 " +
                                                "WHERE seq=" + task.seq;

                    com.CommandText = sql;
                    com.ExecuteNonQuery();

                    sql = @"INSERT INTO task_history (taskSeq, content, rgstDate) VALUES "
                                            + "("+task.seq+", '처리완료', NOW()) ";

                    com.CommandText = sql;
                    com.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("데이터베이스 연결오류");
                }
                con.Close();

                this.Close();
                adminHome.Location = new Point(this.Location.X, this.Location.Y);
                adminHome.Show();
            }
        }

        private void addHistoryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            HistoryCreate hc = new HistoryCreate(this, task);
            hc.Location = new Point(this.Location.X, this.Location.Y);
            hc.ShowDialog();
        }
    }
}
