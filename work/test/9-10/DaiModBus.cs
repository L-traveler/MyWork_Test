using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppTest9_10
{
    public partial class DaiModBus : Form
    {
        SerialPort port;
        IModbusSerialMaster master;
        public DaiModBus()
        {
            InitializeComponent();

        }

        //打开串口按钮
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //创建串口
                port = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
                //打开串口
                port.Open();
                //创建主站接口对象
                master = ModbusSerialMaster.CreateRtu(port);
                MessageBox.Show("连接成功");
                //master.Transport.ReadTimeout = 2000; // 读超时
                //master.Transport.Retries = 3; // 重试次数
            }
            catch (Exception ex)
            {

                MessageBox.Show("连接失败" + ex);
            }



        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //await master.WriteSingleRegisterAsync(2, 100, 1);

                //测试
                await master.WriteSingleRegisterAsync(2, 1, 1);
            }
            catch (Exception ex)
            {

                MessageBox.Show("连接失败" + ex);
            }

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //await master.WriteSingleRegisterAsync(2, 100, 0);

                //测试
                await master.WriteSingleRegisterAsync(2, 1, 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show("连接失败" + ex);
            }

        }

        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {
                await master.WriteSingleRegisterAsync(2, 101, 1);
            }
            catch (Exception ex)
            {

                MessageBox.Show("连接失败" + ex);
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            try
            {
                await master.WriteSingleRegisterAsync(2, 101, 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show("连接失败" + ex);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int speed) || speed < 0 || speed > 10000)
            {
                MessageBox.Show("转速输入有误或超出范围");
                return;
            }
            try
            {
                await master.WriteSingleRegisterAsync(2, 103, (ushort)speed);
            }
            catch (Exception ex)
            {

                MessageBox.Show("连接失败" + ex);
            }
        }
    }
}
