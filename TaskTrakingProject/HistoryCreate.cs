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
    public partial class HistoryCreate : Form
    {
        ItemRetrieve itemRetrieve;
        Task task;

        public HistoryCreate()
        {
            InitializeComponent();
        }

        public HistoryCreate(ItemRetrieve itemRetrieve, Task task)
        {
            InitializeComponent();

            this.itemRetrieve = itemRetrieve;
            this.task = task;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(Database.getConnection()))
            {
                MySqlCommand com = con.CreateCommand();

                try
                {
                    con.Open();

                    string sql = @"INSERT INTO task_history (taskSeq, content, rgstDate) VALUES "
                                            + "("+task.seq+", '"+contentBox.Text+"' , NOW())";

                    com.CommandText = sql;
                    com.ExecuteNonQuery();

                    sql = @"UPDATE task SET updateRead=1 " +
                                                    "WHERE seq=" + task.seq;

                    com.CommandText = sql;
                    com.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("데이터베이스 연결오류");
                }
                con.Close();

                this.Close();
                itemRetrieve.Location = new Point(this.Location.X, this.Location.Y);
                itemRetrieve.Show();
            }
        }
    }
}
