using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppTest9_8
{
    public partial class Form1 : Form
    {
        private int lableHight = 0;
        private Random random = new Random();
        private System.Windows.Forms.Timer GloBalTimer=new System.Windows.Forms.Timer();
        private int speed = 2;
        private int score = 0;
        private List<LabelAndTimer> labTimaerlist = new List<LabelAndTimer>();

        public Form1()
        {
            InitializeComponent();
            InitGame();
        }

        private void InitGame()
        {
            
            GloBalTimer.Interval=1000;
            GloBalTimer.Tick += GloBalTimer_Tick;
            this.KeyPreview = true;
            this.ActiveControl = null;
            this.KeyUp += Form1_KeyUp;
        }

        private void Form1_KeyUp(object? sender, KeyEventArgs e)
        {
            for (int i = 0; i < labTimaerlist.Count; i++)
            {
                if (Enum.TryParse(labTimaerlist[i].lab.Text,true,out Keys k ))
                {
                    if (k!=e.KeyCode)
                    {
                        continue;
                    }
                    else
                    {
                        labTimaerlist[i].labTimer.Stop();
                        panel1.Controls.RemoveAt(i);
                        
                        labTimaerlist.RemoveAt(i);

                        label2.Text=(++score).ToString();
                    }
                    return;
                }
            }
        }

        private void GloBalTimer_Tick(object? sender, EventArgs e)
        {
            
            CreateLabel();


        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //开始游戏
            GloBalTimer.Start();
            

        }
        private void CreateLabel()
        {
            //创建label
            Label lab = new Label();
            lab.Size = new Size(30, 30);
            lab.Location = new Point(random.Next(0, panel1.Width - lab.Width), -lab.Height);
            lab.Text = ((char)random.Next(65, 91)).ToString();
            panel1.Controls.Add(lab);
            //创建timer
            System.Windows.Forms.Timer timer = new();
            timer.Interval = 20;
            timer.Tick += (sender, e) =>
            {
                //向下移动几停止的操作
                lab.Top += speed;
                
                if (lab.Top > panel1.Height - lab.Height)
                {
                    
                    GloBalTimer.Stop();
                    labTimaerlist.ForEach(item=>item.labTimer.Stop());
                    MessageBox.Show("Game Over");
                    panel1.Controls.Clear();
                    labTimaerlist.Clear();
                    score = 0;
                    label2.Text = "0";

                }
            };
            timer.Start();
            //组装
            labTimaerlist.Add(new LabelAndTimer(lab,timer));
        }

    }
}
