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
    public partial class ItemCreate : Form
    {
        UserHome userHome;
        ItemRetrieve itemRetrieve;
        Member member;
        Task task;
        int formType { get; set; } // 0은 생성, 1은 수정

        public ItemCreate()
        {
            InitializeComponent();
        }

        public ItemCreate(UserHome userHome, Member member)
        {
            InitializeComponent();

            this.userHome = userHome;
            this.member = member;
            formType = 0;
        }

        public ItemCreate(ItemRetrieve itemRetrieve, Member member, Task task)
        {
            InitializeComponent();

            this.itemRetrieve = itemRetrieve;
            this.member = member;
            this.task = task;
            formType = 1;
        }

        private void ItemCreate_Load(object sender, EventArgs e)
        {
            if(formType==0)
            {
                updateBtn.Hide();
            }
            else
            {
                createBtn.Hide();
                GetTaskInfo();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            if (formType == 0)
            {
                userHome.Location = new Point(this.Location.X, this.Location.Y);
                userHome.Show();
            }
            else
            {
                itemRetrieve.Location = new Point(this.Location.X, this.Location.Y);
                itemRetrieve.Show();
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            AddTask();

            this.Close();
            userHome.Location = new Point(this.Location.X, this.Location.Y);
            userHome.Show();
        }

        private void AddTask()
        {
            Task newTask = new Task();
            newTask.title = titleBox.Text;
            newTask.content = contentBox.Text;
            newTask.rgstMemId = member.id;

            if (newTask.title.CompareTo("") == 0)
            {
                MessageBox.Show("제목을 입력해주세요");
            }
            else if (newTask.content.CompareTo("") == 0)
            {
                MessageBox.Show("내용을 입력해주세요");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(Database.getConnection());
                MySqlCommand com = con.CreateCommand();

                try
                {
                    con.Open();

                    string sql = @"INSERT INTO task (title, content, rgstMemId, status, rgstDate, updateRead) VALUES "
                                            + "('" + newTask.title + "','" + newTask.content + "','" + newTask.rgstMemId + "',0,"
                                            + "NOW(),0)";

                    com.CommandText = sql;
                    com.ExecuteNonQuery();

                    sql = @"INSERT INTO task_history (taskSeq, content, rgstDate) "
                                            + "SELECT MAX(seq) as taskSeq, '등록' as content, NOW() as rgstDate "
                                            + "FROM task WHERE rgstMemId='" + newTask.rgstMemId + "'";

                    com.CommandText = sql;
                    com.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("데이터베이스 연결오류");
                    con.Close();
                }
                con.Close();
            }
        }

        private void ItemCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            if (formType==0)
            {
                userHome.Location = new Point(this.Location.X, this.Location.Y);
                userHome.Show();
            }
            else
            {
                itemRetrieve.Location = new Point(this.Location.X, this.Location.Y);
                itemRetrieve.Show();
            }
        }

        private void GetTaskInfo()
        {
            titleBox.Text = task.title;
            contentBox.Text = task.content;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(Database.getConnection()))
            {
                MySqlCommand com = con.CreateCommand();

                try
                {
                    con.Open();

                    string sql = @"UPDATE task SET title='" +titleBox.Text+"', content='"+contentBox.Text+"' "+
                                                "WHERE seq=" + task.seq;

                    com.CommandText = sql;
                    com.ExecuteNonQuery();

                    this.Close();
                    itemRetrieve.Location = new Point(this.Location.X, this.Location.Y);
                    itemRetrieve.Show();
                }
                catch
                {
                    MessageBox.Show("데이터베이스 연결오류");
                }
                con.Close();
            }
        }
    }
}
