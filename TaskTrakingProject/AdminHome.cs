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
    public partial class AdminHome : Form
    {
        MainForm mainForm;
        Member member;
        List<Task> standTaskList = new List<Task>();
        List<Task> startTaskList = new List<Task>();
        List<Task> endTaskList = new List<Task>();

        public AdminHome()
        {
            InitializeComponent();
        }

        public AdminHome(MainForm mainForm, Member member)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.member = member;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Location = new Point(this.Location.X, this.Location.Y);
            mainForm.Show();
        }

        private void LoadTasks()
        {
            using (MySqlConnection con = new MySqlConnection(Database.getConnection()))
            {
                MySqlCommand com = con.CreateCommand();

                try
                {
                    con.Open();

                    string sql = @"SELECT * FROM task " +
                                                "ORDER BY updateRead DESC, rgstDate DESC";

                    com.CommandText = sql;
                    MySqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        Task task = new Task();
                        task.seq = System.Convert.ToInt32(reader["seq"]);
                        task.title = reader["title"].ToString();
                        task.rgstDate = reader["rgstDate"].ToString();
                        task.status = System.Convert.ToInt32(reader["status"]);
                        task.chargeMemId = reader["chargeMemId"].ToString();
                        bool temp = task.chargeMemId.CompareTo(member.id) == 0;

                        switch (task.status)
                        {
                            case 0:
                                standTaskList.Add(task);
                                break;
                            case 1:
                                if(temp) startTaskList.Add(task);
                                break;
                            case 2:
                                if (temp) endTaskList.Add(task);
                                break;
                            default:
                                break;
                        }

                        if(task.status==0 || temp) AddListViewTaskItem(task);
                    }

                }
                catch
                {
                    MessageBox.Show("데이터베이스 연결오류");
                }
                con.Close();
            }
        }

        private void AddListViewTaskItem(Task task)
        {
            ListViewItem item = new ListViewItem(task.title, task.status);
            item.SubItems.Add(task.rgstDate);

            switch (task.status)
            {
                case 0:
                    standList.Items.Add(item);
                    break;
                case 1:
                    startList.Items.Add(item);
                    break;
                case 2:
                    endList.Items.Add(item);
                    break;
                default:
                    break;
            }
        }

        private void standList_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < standList.Items.Count; i++)
            {
                var rectangle = standList.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    this.Hide();

                    ItemRetrieve ir = new ItemRetrieve(this, standTaskList[i], member);
                    ir.Location = new Point(this.Location.X, this.Location.Y);
                    ir.ShowDialog();
                    break;
                }
            }
        }

        private void startList_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < startList.Items.Count; i++)
            {
                var rectangle = startList.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    this.Hide();

                    ItemRetrieve ir = new ItemRetrieve(this, startTaskList[i], member);
                    ir.Location = new Point(this.Location.X, this.Location.Y);
                    ir.ShowDialog();
                    break;
                }
            }
         }

        private void endList_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < endList.Items.Count; i++)
            {
                var rectangle = endList.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    this.Hide();

                    ItemRetrieve ir = new ItemRetrieve(this, endTaskList[i], member);
                    ir.Location = new Point(this.Location.X, this.Location.Y);
                    ir.ShowDialog();
                    break;
                }
            }
        }

        private void AdminHome_VisibleChanged(object sender, EventArgs e)
        {
            standTaskList.Clear();
            startTaskList.Clear();
            endTaskList.Clear();
            standList.Items.Clear();
            startList.Items.Clear();
            endList.Items.Clear();

            nameBox.Text = member.name;
            LoadTasks();
        }
    }
}
