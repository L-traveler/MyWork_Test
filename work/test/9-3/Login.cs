using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsAppTest9_2.Mysql;

namespace WinFormsAppTest9_2
{
    public partial class Login : Form
    {
        public event Action<string> loginMask;

        public Login()
        {
            InitializeComponent();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from user where username=@username and password=@password ";
            string Name = input1.Text;
            string Pwd = input2.Text;

            MySql mysql = new MySql("test01");

            if (Name.Trim() == "" || Pwd.Trim() == "")
            {
                MessageBox.Show("用户名或密码不能为空！！");
            }
            else
            {
                //读取
               await mysql.ConAndHandler(sql, cmd =>
                {
                    cmd.Parameters.AddWithValue("@username", Name);
                    cmd.Parameters.AddWithValue("@password", Pwd);

                    MySqlDataReader res = cmd.ExecuteReader();
                    bool row = res.Read();
                    if (row)
                    {
                        MessageBox.Show("登录成功");
                        loginMask.Invoke("已登录");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("登录失败");
                        loginMask.Invoke("未登录");
                    }

                    return true;
                });
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var regis=new Register();
            regis.Show();
            regis.FormClosing += Regis_FormClosing;
            this.Hide();
        }

        private void Regis_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
