using System.IO.Ports;
using System.Text;

namespace WinFormsAppTest9_10
{
    public partial class MyPort : Form
    {
        private SerialPort Port;
        private Stream stream;
        private byte[] Buffer;
        private int Num=0;
        public MyPort()
        {
            InitializeComponent();
            this.Shown += MyPort_Shown;
        }

        private void MyPort_Shown(object? sender, EventArgs e)
        {
            button1.Click += OpenPort;
            button2.Click += SendData;
        }

        private async void SendData(object? sender, EventArgs e)
        {
            //写
            string mesData=textBox1.Text;
            Buffer = new byte[1024];
            Buffer=Encoding.UTF8.GetBytes(mesData);
            try
            {
                await stream.WriteAsync(Buffer);
            }
            catch (Exception)
            {

                throw;
            }
            textBox1.Text = "";
        }

        private void OpenPort(object? sender, EventArgs e)
        {
            //创建串口
            Port = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);
            //打开串口
            Port.Open();
            //创建数据流
             stream = Port.BaseStream;
            //读
            ReadData();
        }
        private  async void ReadData()
        {
            Buffer = new byte[1024];
            while (true) {
                var len = await stream.ReadAsync(Buffer);
                if (len == 0)
                {
                    MessageBox.Show("连接失败");
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
    }
}
