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
            minu = time.Minute;
            hour = time.Hour * 5;
            //MessageBox.Show(time.ToString());
            panel1.Paint += Panel1_Paint;
            timer = new System.Windows.Forms.Timer();

            timer.Interval = 1000;

            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {

            Second++;
            if (Second % 60 == 0)
            {
                minu++;
                if (minu % 60 == 0)
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


            using (Pen penBlack = new Pen(Color.Black, 2))
            {
                //画钟
                g.DrawEllipse(penBlack, cx - r, cy - r, 2 * r, 2 * r);

                //g.DrawLine(penBlack,cx+r,cy, cx + r- kedulong, cy);
                int tmpKedulong = kedulong;//临时变量如果是5的倍数让刻度的长度乘以2
                for (int i = 0; i < count; i++)
                {
                    if (i % 5 == 0)
                    {
                        tmpKedulong = 2 * kedulong;

                    }
                    //画钟表刻度
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

        private void BiaoPanShow()
        {
            int RX = 400;
            int RY = 110;
            int R = 100;
            int ShortLine = 10;
            int ShortLineCount = 30;
            int CurrentTemp = 20;
            double EveryDeg = 6;
            double EveryTemp = 2;

            using (Pen penGreen = new Pen(Color.Green, 4))
            {
                g.DrawArc(penGreen, 300, 10, 200, 200, 180, 180);

                for (int i = 0; i <= 30; i++)
                {
                    var LineLength = ShortLine;
                    if (i % 10 == 0)
                    {
                        LineLength = ShortLine + 5;
                    }
                    var StartX = RX + Math.Cos((180 + EveryDeg * i) * Math.PI / 180) * R;
                    var StartY = RY + Math.Sin((180 + EveryDeg * i) * Math.PI / 180) * R;
                    var EndX = RX + Math.Cos((180 + EveryDeg * i) * Math.PI / 180) * (R - LineLength);
                    var EndY = RY + Math.Sin((180 + EveryDeg * i) * Math.PI / 180) * (R - LineLength);

                    g.DrawLine(Pens.Orange, (int)StartX, (int)StartY, (int)EndX, (int)EndY);

                    if (i % 10 == 0)
                    {
                        using (Brush brushText = new SolidBrush(Color.Black))
                        using (StringFormat sf = new StringFormat())
                        using (Font font = new Font("微软雅黑", 8))
                        {
                            /*
                                0 60 60
                                10 60 40
                                20 60 20
                                30 60 0
                            */
                            sf.Alignment = StringAlignment.Center;
                            sf.LineAlignment = StringAlignment.Center;
                            var FontEndX = RX + Math.Cos(-EveryDeg * i * Math.PI / 180) * (R - LineLength - 10);
                            var FontEndY = RY + Math.Sin(-EveryDeg * i * Math.PI / 180) * (R - LineLength - 10);
                            g.DrawString(((30 - i) * EveryTemp).ToString(), font, brushText, (float)FontEndX, (float)FontEndY, sf);
                        }
                    }
                }

                var PointX = RX + Math.Cos(-(180 - CurrentTemp / EveryTemp * EveryDeg) * Math.PI / 180) * (R - 10);
                var PointY = RY + Math.Sin(-(180 - CurrentTemp / EveryTemp * EveryDeg) * Math.PI / 180) * (R - 10);
                g.DrawLine(Pens.Green, (int)PointX, (int)PointY, (int)RX, (int)RY);
                Point[] pts = new Point[3];
                // 三个角度，0°、120°、240°
                double[] angles = { -(180 - CurrentTemp / EveryTemp * EveryDeg), -(180 - CurrentTemp / EveryTemp * EveryDeg) + 150, -(180 - CurrentTemp / EveryTemp * EveryDeg) + 210 };

                for (int i = 0; i < 3; i++)
                {
                    double rad = angles[i] * Math.PI / 180;
                    int x = (int)PointX + (int)(5 * Math.Cos(rad));
                    int y = (int)PointY + (int)(5 * Math.Sin(rad));
                    pts[i] = new Point(x, y);
                }

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(180, 255, 0, 0)))
                {
                    g.FillPolygon(brush, pts);
                }
            }

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

