namespace WinFormsAppTest8_25
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitForm();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void InitForm()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile("images/off.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = Image.FromFile("images/cat.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.Image = Image.FromFile("images/cat.jpg");
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Image = Image.FromFile("images/bird.jpg");
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.Image = Image.FromFile("images/eagle.jpg");

            
            

        }



        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Btn1.Text == "打开")
            {
                pictureBox1.Image = Image.FromFile("images/on.png");
                Btn1.Text = "关闭";

            }
            else if (Btn1.Text == "关闭")
            {
                pictureBox1.Image = Image.FromFile("images/off.png");
                Btn1.Text = "打开";


            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            //panel1.Controls.GetChildIndex();
            initBtn();
            CatBtn.BackColor = Color.Green;
            CatBtn.ForeColor = Color.White;
            pictureBox2.Image = Image.FromFile("images/cat.jpg");
            //EagleBtn.BackColor = Color.Gray;
            //EagleBtn.ForeColor = Color.Black;
            //BridBtn.BackColor = Color.Gray;
            //BridBtn.ForeColor = Color.Black;
        }

        private void EagleBtn_Click(object sender, EventArgs e)
        {
            initBtn();
            EagleBtn.BackColor = Color.Green;
            EagleBtn.ForeColor = Color.White;
            pictureBox2.Image = Image.FromFile("images/eagle.jpg");
            //CatBtn.BackColor = Color.Gray;
            //CatBtn.ForeColor = Color.Black;
            //BridBtn.BackColor = Color.Gray;
            //BridBtn.ForeColor = Color.Black;
        }

        private void BridBtn_Click(object sender, EventArgs e)
        {
            initBtn();
            BridBtn.BackColor = Color.Green;
            BridBtn.ForeColor = Color.White;
            pictureBox2.Image = Image.FromFile("images/bird.jpg");
            //CatBtn.BackColor = Color.Gray;
            //CatBtn.ForeColor = Color.Black;
            //EagleBtn.BackColor = Color.Gray;
            //EagleBtn.ForeColor = Color.Black;
        }
        public void initBtn()
        {
            //EagleBtn.BackColor = Color.Gray;
            //EagleBtn.ForeColor = Color.Black;
            //BridBtn.BackColor = Color.Gray;
            //BridBtn.ForeColor = Color.Black;
            //CatBtn.BackColor = Color.Gray;
            //CatBtn.ForeColor = Color.Black;

            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                panel1.Controls[i].BackColor = Color.DarkGray;
                panel1.Controls[i].ForeColor = Color.Black;

            }
        }

        
    }
}
