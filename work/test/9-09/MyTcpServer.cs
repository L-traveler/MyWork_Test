using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WinFormsAppTest9_9
{
    public partial class MyTcpServer : Form
    {
        private TcpListener TLServer;
        private NetworkStream Stream;
        private int Num = 0;
        private byte[] Buffer;
        public MyTcpServer()
        {
            InitializeComponent();
            new MyTcpClient().Show();
            this.Shown += MyTcpServer_Shown;
        }

        private void MyTcpServer_Shown(object? sender, EventArgs e)
        {

            button1.Click += CreateTcpListener;
            button2.Click += SendData;




        }

        private async void CreateTcpListener(object? sender, EventArgs e)
        {
            bool isPort = int.TryParse(textBox1.Text, out int Port) && Port >= 0 && Port <= 65535;
            if (!isPort)
            {
                Console.WriteLine("端口号输入格式有误！");
                return;
            }
            //创建tcp服务监听器
            TLServer = new TcpListener(System.Net.IPAddress.Any, Port);
            Console.WriteLine("TCPServer创建成功");
            //打开监听器
            TLServer.Start();

            try
            {
                //等待接受监听器接受的客户端对象
                var TClient = await TLServer.AcceptTcpClientAsync();
                Console.WriteLine("有人连接：" + TClient.Client.RemoteEndPoint);
                //创建数据流
                Stream = TClient.GetStream();
            }
            catch (Exception ex)
            {
                Console.WriteLine("连接断开");

            }

            //读取，

            await ReadData();
        }

        private async Task ReadData()
        {
            //byte[] Buffer = new byte[1024];
            while (true)
            {
                Buffer = new byte[1024];
                int len = await Stream.ReadAsync(Buffer);
                if (len == 0)
                {
                    Console.WriteLine("连接断开");
                    return;
                }
                string Revice = Encoding.UTF8.GetString(Buffer, 0, len);
                Label lb = new Label();
                lb.Text = Revice;
                lb.Size = new Size(300, 30);
                lb.Location = new Point(0, 30 * Num);
                Num++;
                panel1.Controls.Add(lb);

            }
        }

        private async void SendData(object? sender, EventArgs e)
        {
            string messData=textBox2.Text;
            Buffer = new byte[1024];
            Buffer=Encoding.UTF8.GetBytes(messData);
            try
            {
                await Stream.WriteAsync(Buffer);
            }
            catch (Exception)
            {

                Console.WriteLine("连接断开");
            }
            
            textBox2.Text = "";
        }
    }
}
