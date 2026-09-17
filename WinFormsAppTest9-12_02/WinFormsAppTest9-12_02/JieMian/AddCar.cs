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

namespace WinFormsAppTest9_12_02
{
    public partial class AddCar : Form
    {

        public AddCar()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //校验
            string carId = textBox1.Text;
            string carTy = textBox2.Text;
            

            bool isCarId = carId.Trim() != "" && Regex.IsMatch(carId, @"^\S[A-Z0-9]{6}$");
            bool isCarTy = carTy.Trim()!="";
            bool isCarPrice = decimal.TryParse(textBox3.Text, out decimal carPrice);

            if (!isCarId)
            {
                MessageBox.Show("车牌号输入有误！");
                return;
            }
            if (!isCarTy)
            {
                MessageBox.Show("车类型输入有误！");
                return;
            }
            if (!isCarPrice)
            {
                MessageBox.Show("车辆价格入有误！");
                return;
            }
            



           var car= new Car(carId, carTy, true, carPrice);
            var mysql=new Mysql("test01");

            bool isRight=await MySqlHander.SearchOne("car", "card", carId);
            if (isRight)
            {
                string sql = $"insert into car (card,type,status,price) value('{car.CarUid}','{car.CarTp}',1,{car.Price})";

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
