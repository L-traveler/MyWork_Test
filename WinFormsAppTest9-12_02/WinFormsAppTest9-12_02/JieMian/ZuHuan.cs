using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsAppTest9_12_02.Class;
using WinFormsAppTest9_12_02.MySql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsAppTest9_12_02.JieMian
{
    public partial class ZuHuan : Form
    {
        string id = Properties.Settings.Default.cardId;
        public ZuHuan()
        {
            InitializeComponent();
            //回显
            textBox1.Text = Properties.Settings.Default.card;
            textBox2.Text = Properties.Settings.Default.type;
            
            // 只能下拉框写入
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            this.Shown += ZuHuan_Shown;
        }

        private async void ZuHuan_Shown(object? sender, EventArgs e)
        {
            DataTable userDt = await MySqlHander.SearchAll("user_info");
            comboBox1.Items.Clear();

            //循环每一行，取出name添加到下拉框
            foreach (DataRow row in userDt.Rows)
            {
                string name = row["name"].ToString();
                comboBox1.Items.Add(name);
            }
        }
        //添加租车记录
        private async void button1_Click(object sender, EventArgs e)
        {

            string carId = "";
            string userId = "";
            DateTime rentTime = DateTime.Now;
            DateTime retTime = DateTime.Now; ;
            TimeSpan diff = retTime - rentTime;
            string pay = "";

            decimal.TryParse(pay, out decimal payM);
            decimal payMoney = (decimal)diff.TotalHours * payM;

            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("内容不能为空");
                return;
            }
            //用户
            DataTable userDt = await MySqlHander.SearchAll("user_info", "name", comboBox1.Text);
            foreach (DataRow row in userDt.Rows)
            {
                userId = row["id"].ToString();

            }
            //车
            DataTable carDt = await MySqlHander.SearchAll("car", "card", textBox1.Text);
            foreach (DataRow row in carDt.Rows)
            {
                carId = row["id"].ToString();
                pay = row["price"].ToString();
            }
            //
            int.TryParse(carId, out int carID);
            int.TryParse(userId, out int userID);


            var renret = new RenRet(carID, userID, rentTime, retTime, payMoney);
            var mysql = new Mysql("test01");


            string sql = $"insert into rent_return (car_id,user_id,rent_time,return_time,pay_money) value('{renret.car_id}','{renret.user_id}','{rentTime}','{retTime}','{renret.pay_money}')";

            bool isAdd = await mysql.Hander(sql);
            if (isAdd)
            {

                string Updatasql = $"UPDATE  car SET status= 0 WHERE id = {id}";
                await mysql.Hander(Updatasql);
                MessageBox.Show("添加成功");

                this.Close();

            }


        }
    }
}
