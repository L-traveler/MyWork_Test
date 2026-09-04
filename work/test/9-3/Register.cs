using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinFormsAppTest9_2.Mysql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppTest9_2
{

    public partial class Register : Form
    {
        enum Gender
        {
            男,
            女
        };
        public Register()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into user (username,password,age,gender,banji) value( @name,@password,@age,@gender,@banji)";

            string sqlname = "select * from user where username=@username";
            //赋值
            string Name = input1.Text;
            string Password = input2.Text;
            string rePassword = input3.Text;
            string Age = input4.Text;
            string Banji = select1.Text;
            Gender gender;

            if (radio1.Checked)
            {
                gender = Gender.男;
            }
            else if (radio2.Checked)
            {
                gender = Gender.女;
            }
            else
            {
                MessageBox.Show("请选择性别");
                return;
            }

            //校验
            if (Name.Length < 2 || Name.Length > 10)
            {
                MessageBox.Show("用户名的长度要>=2,并且小于10");
                return;
            }
            if (Password.Length < 6 || Password.Length > 15)
            {
                MessageBox.Show("密码的长度至少6位,并且小于16");
                return;
            }
            if (Password != rePassword)
            {
                MessageBox.Show("两次输入的密码不一致");
                return;
            }

            if (!int.TryParse(Age, out int age))
            {
                MessageBox.Show("请输入年龄格式不对");
                return;
            }
            if (int.Parse(Age) < 0 || int.Parse(Age) > 120)
            {
                MessageBox.Show("输入的年龄不现实");
                return;
            }
            if (string.IsNullOrEmpty(Banji))
            {
                MessageBox.Show("请选择班级！");
                return;
            }
            foreach (var item in select1.Items)
            {
                if (!item.ToString().Contains(Banji))
                {
                    MessageBox.Show("请选择正确班级！");
                    return;
                }
            }
            



            MySql mysql = new MySql("test01");

            bool res=await mysql.ConAndHandler(sqlname, cmd =>
            {
                cmd.Parameters.AddWithValue("@username", Name);
                
                MySqlDataReader reader=cmd.ExecuteReader();
                bool isrow=reader.Read();
                if (isrow)
                {
                    MessageBox.Show("用户名已存在");
                    return false;
                }
                return true;
            });

            if (!res)
            {
                return ;
            }

            await mysql.ConAndHandler(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@password", Password);
                cmd.Parameters.AddWithValue("@age", Age);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@banji", Banji);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("添加成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
                return true;
            });


        }
    }
}
