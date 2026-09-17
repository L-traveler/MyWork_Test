using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinFormsAppTest9_12_02.Class;
using WinFormsAppTest9_12_02.MySql;

namespace WinFormsAppTest9_12_02.JieMian
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();

        }

        private  async void button1_Click(object sender, EventArgs e)
        {
            //校验
            string userName = textBox1.Text;
            string userID = textBox2.Text;
            string gender = textBox3.Text;
            string phoneNum = textBox4.Text;
            string Motto = textBox5.Text;


            bool isUserName = userName.Trim() != "";
            bool isUserID = userID.Trim() != "" && Regex.IsMatch(userID, @"^[1][0-9]{16}[0-9Xx]$");


            bool isPhoneNum = Regex.IsMatch(phoneNum, @"^[1][0-9]{10}$");
            bool isMotto = Motto.Trim() != "";

            if (!isUserName)
            {
                MessageBox.Show("用户名输入有误！");
                return;
            }
            if (!isUserID)
            {
                MessageBox.Show("身份证号输入有误！");
                return;
            }
            if (gender!="男"&& gender != "女")
            {
                MessageBox.Show("性别输入有误！");
                return;
            }
            if (!isPhoneNum)
            {
                MessageBox.Show("手机号输入有误！");
                return;
            }
            if (!isMotto)
            {
                MessageBox.Show("座右铭输入有误！");
                return;
            }

            var user = new User(userName, userID, gender, phoneNum, Motto);
            var mysql = new Mysql("test01");

            bool isRight = await MySqlHander.SearchOne("user_info","id_card", userID);
            if (isRight)
            {
                string sql = $"insert into user_info (name,id_card,reg_time,gender,tel,motto) value('{user.name}','{user.idCard}','{DateTime.Now}','{user.gender}','{user.tel}','{user.motto}')";

                bool isAdd = await mysql.Hander(sql);
                if (isAdd)
                {
                    MessageBox.Show("添加成功");
                    this.Close();
                }
            }
            
        }
    }
}
