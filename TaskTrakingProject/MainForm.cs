using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TaskTrakingProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string tempId = inputId.Text;
            string tempPw = inputPwd.Text;

            if (tempId.CompareTo("") == 0 || tempPw.CompareTo("") == 0)
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요");
            }
            else
            {
                Member loginMem = AuthCheck(tempId, tempPw);
                
                if (loginMem!=null)
                {
                    this.Hide();
                    if(loginMem.auth == 0)
                    {
                        UserHome uh = new UserHome(this, loginMem);
                        uh.Location = new Point(this.Location.X, this.Location.Y);
                        uh.ShowDialog();
                    }
                    else
                    {
                        AdminHome ah = new AdminHome(this, loginMem);
                        ah.Location = new Point(this.Location.X, this.Location.Y);
                        ah.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("입력하신 계정이 존재하지 않습니다.");
                }
            }
        }

        private Member AuthCheck(string tempId, string tempPw)
        {
            string DecrepKey = "seyoo";
            MySqlConnection con = new MySqlConnection(Database.getConnection());
            MySqlCommand com = con.CreateCommand();

            try
            {
                con.Open();

                string sql = @"SELECT id, AES_DECRYPT(UNHEX(pwd),'" +
                            DecrepKey + "') AS pwd, name, auth FROM member WHERE id='" + tempId + "'";

                com.CommandText = sql;
                MySqlDataReader reader = com.ExecuteReader();

                reader.Read();

                Member tempM = new Member();
                string readerPw = Encoding.Default.GetString((System.Byte[])reader["pwd"]);

                if (readerPw.CompareTo(tempPw) == 0)
                {
                    tempM.id = reader["id"].ToString();
                    tempM.name = reader["name"].ToString();
                    tempM.auth = System.Convert.ToInt32(reader["auth"]);

                    return tempM;
                }

                con.Close();
                return null;
            }
            catch
            {
                con.Close();
                return null;
            }
        }
    }
}
