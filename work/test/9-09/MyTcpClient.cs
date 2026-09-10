using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppTest9_9
{
    public partial class MyTcpClient : Form
    {
        private NetworkStream Stream;
        private byte[] Buffer;
        private int Num;
        public MyTcpClient()
        {
            InitializeComponent();
            this.Shown += MyTcpClient_Shown;
        }

        private void MyTcpClient_Shown(object? sender, EventArgs e)
        {
            button1.Click += ConnectServer;

            button3.Click += SendData;


        }

        private async void ConnectServer(object? sender, EventArgs e)
        {


            if (!IPAddress.TryParse(textBox1.Text, out IPAddress Ip))
            {
                MessageBox.Show("ip输入有误");
                return;
            }
            if (!int.TryParse(textBox2.Text, out int Port))
            {
                MessageBox.Show("ip输入有误");
                return;
            }


            //创建客户端
            TcpClient client = new TcpClient();
            try
            {
                //客户端连接，输入自己的ip和服务端对应的的端口
                await client.ConnectAsync(Ip, Port);
                //创建数据流
                Stream = client.GetStream();
            }
            catch (Exception)
            {

                MessageBox.Show("连接失败");
            }

            //读

            while (true)
            {
                Buffer = new byte[1024];
                int len = await Stream.ReadAsync(Buffer, 0, Buffer.Length);
                if (len == 0)
                {
                    MessageBox.Show("连接失败");
                }
                string Revice = Encoding.UTF8.GetString(Buffer);
                Label lb = new Label();
                lb.Text = Revice;
                lb.Size = new Size(300, 30);
                lb.Location = new Point(0, 30 * Num);
                Num++;
                panel1.Controls.Add(lb);
            }

        }

        private async void SendData(object sender, EventArgs e)
        {
            Buffer = new byte[1024];
            string mesData=textBox3.Text;

            Buffer=Encoding.UTF8.GetBytes(mesData);
            try
            {
                await Stream.WriteAsync(Buffer, 0, Buffer.Length);
            }
            catch (Exception)
            {
                MessageBox.Show("连接断开");
                
            }

            textBox3.Text = "";

        }
    }
}
