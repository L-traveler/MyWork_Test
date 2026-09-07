using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppTest9_7
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private int Second;
        private int minu;
        private int hour;
        private Graphics g;//创建图像对象
        public Form1()
        {
            InitializeComponent();

            DateTime time = DateTime.Now;
            Second = time.Second;
            minu=time.Minute;
            hour = time.Hour*5;
            //MessageBox.Show(time.ToString());
            panel1.Paint += Panel1_Paint;
            timer=new System.Windows.Forms.Timer();
            
            timer.Interval = 1000;
           
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            
            Second++;
            if (Second%60==0)
            {
                minu++;
                if (minu%60==0)
                {
                    hour++;
                }
            }
            panel1.Invalidate();
        }

        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {

             g = e.Graphics;//创建图像对象
            ClockShow();
            BiaoPanShow();

        }

        //画时钟
        private void ClockShow()
        {
            int r = 100;//半径
            int cx = 110;//圆心到画布x轴的距离
            int cy = 110;//圆心到画布Y轴的距离
            int kedulong = 10;//刻度的长度
            
            double pai = Math.PI;
            int count = 60;//刻度总数
            int keduarg = 360 / count;//每个刻度之间的角度

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //画钟表刻度
            using (Pen penBlack = new Pen(Color.Black, 2))
            {
                g.DrawEllipse(penBlack, cx - r, cy - r, 2 * r, 2 * r);

                //g.DrawLine(penBlack,cx+r,cy, cx + r- kedulong, cy);
                int tmpKedulong = kedulong;//临时变量如果是5的倍数让刻度的长度乘以2
                for (int i = 0; i < count; i++)
                {
                    if (i % 5 == 0)
                    {
                        tmpKedulong = 2 * kedulong;

                    }
                    g.DrawLine(penBlack, (int)(cx + r * Math.Cos(keduarg * i * pai / 180)), (int)(cy + r * Math.Sin(keduarg * i * pai / 180)), (int)(cx + (r - tmpKedulong) * Math.Cos(keduarg * i * pai / 180)), (int)(cy + (r - tmpKedulong) * Math.Sin(keduarg * i * pai / 180)));

                    tmpKedulong = kedulong;
                }

            }
            //画钟表指针
            //秒针
            using (Pen penRed = new Pen(Color.Red, 2))
            {

                g.DrawLine(penRed, cx, cy, (int)(cx + (r - kedulong) * Math.Cos(-90 * pai / 180 + (keduarg) * Second * pai / 180)), (int)(cy + (r - kedulong) * Math.Sin(-90 * pai / 180 + keduarg * Second * pai / 180)));

            }
            //分针
            using (Pen penBlack = new Pen(Color.Black, 3))
            {

                g.DrawLine(penBlack, cx, cy, (int)(cx + (r - kedulong - 15) * Math.Cos(-90 * pai / 180 + keduarg * minu * pai / 180)), (int)(cy + (r - kedulong - 15) * Math.Sin(-90 * pai / 180 + keduarg * minu * pai / 180)));

            }
            //时针
            using (Pen penBlack = new Pen(Color.Black, 4))
            {

                g.DrawLine(penBlack, cx, cy, (int)(cx + (r - kedulong - 35) * Math.Cos(-90 * pai / 180 + keduarg * hour * pai / 180)), (int)(cy + (r - kedulong - 35) * Math.Sin(-90 * pai / 180 + keduarg * hour * pai / 180)));

            }
        }

        //半圆表盘

        private void BiaoPanShow() {
            using (Pen penGreen=new Pen(Color.Green,4))
            {
                g.DrawArc(penGreen,300,10,200,200,180,180);


            }
                
        }
    }

    public class DoubleBufferPanel : Panel
    {
        public DoubleBufferPanel()
        {
            //开启双缓冲，消除闪烁
            this.SetStyle(ControlStyles.UserPaint
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
        }
    }
}
