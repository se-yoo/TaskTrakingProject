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
    public partial class UserHome : Form
    {
        MainForm mainForm;
        Member member;
        List<Task> taskList = new List<Task>(); 

        public UserHome()
        {
            InitializeComponent();
        }

        public UserHome(MainForm mainForm, Member member)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.member = member;
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
                                                "WHERE rgstMemId='" + member.id + "' "+
                                                "ORDER BY updateRead DESC, rgstDate DESC";

                    com.CommandText = sql;
                    MySqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        Task task = new Task();
                        task.seq = System.Convert.ToInt32(reader["seq"]);
                        task.title = reader["title"].ToString();
                        task.rgstDate = reader["rgstDate"].ToString();

                        taskList.Add(task);
                        AddListViewTaskItem(task);
                    }

                }
                catch
                {
                    MessageBox.Show("데이터베이스 연결오류");
                }
            }
        }

        private void AddListViewTaskItem(Task task)
        {
            ListViewItem item1 = new ListViewItem(task.title, task.status);
            item1.SubItems.Add(task.rgstDate);

            resultList.Items.Add(item1);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            ItemCreate ic = new ItemCreate(this, member, 0);
            ic.ShowDialog();
        }

        private void UserHome_VisibleChanged(object sender, EventArgs e)
        {
            taskList.Clear();
            resultList.Items.Clear();
            nameBox.Text = member.name;
            LoadTasks();
        }

        private void UserHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void resultList_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < resultList.Items.Count; i++)
            {
                var rectangle = resultList.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    return;
                }
            }
        }
    }
}
