using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace WinFormsAppTest8_25
{
    public partial class Form2 : Form
    {
        private string[] picArr = ["images/cat.jpg", "images/bird.jpg", "images/eagle.jpg"];
        private List<Button> buttonList = new List<Button>();
        private List<Button> buttonList1 = new List<Button>();
        private int index = 0;

        private int speed = 10;
        public Form2()
        {
            InitializeComponent();
            InitForm();


        }
        private void InitForm()
        {
            //初始化

            //轮播
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(picArr[index]);
            buttonList.AddRange([button4, button5]);
            buttonList1.AddRange([button1, button2, button3]);
            foreach (Button button in buttonList)
            {
                button.Click += Button_Click;
            }
            foreach (var button in buttonList1)
            {
                button.Click += Button1_Click;
                buttonList1[index].BackColor = Color.Orange;
                buttonList1[index].ForeColor = Color.White;

            }

            //模拟链接

            label2.ForeColor = Color.Blue;
            label2.Font = new Font("Microsoft YaHei UI", 9f, FontStyle.Regular);

            //获取焦点变亮失去恢复

            textBox2.BackColor = Color.White;
            textBox2.GotFocus += TextBox2_GotFocus;
            textBox2.Leave += TextBox2_Leave;

            button6.BackColor = Color.White;
            button6.GotFocus += Button6_GotFocus;
            button6.Leave += Button6_Leave;

            comboBox1.BackColor = Color.White;
            comboBox1.GotFocus += ComboBox1_GotFocus;
            comboBox1.Leave += ComboBox1_Leave;

            //
            button6.KeyDown += Button6_KeyDown;
        }

        private void Button6_KeyDown(object? sender, KeyEventArgs e)
        {
            var boxPos = button6.Location;
            if (e.KeyCode == Keys.W)
            {
                boxPos.Y -= speed;
            }
            if (e.KeyCode == Keys.S)
            {
                boxPos.Y += speed;
            }
            if (e.KeyCode == Keys.A)
            {
                boxPos.X -= speed;
            }
            if (e.KeyCode == Keys.D)
            {
                boxPos.X += speed;
            }
            button6.Location = boxPos;
        }

        private void ComboBox1_Leave(object? sender, EventArgs e)
        {
            (sender as ComboBox).DroppedDown = false;
        }

        private void ComboBox1_GotFocus(object? sender, EventArgs e)
        {
            (sender as ComboBox).DroppedDown = true;
        }

        private void Button6_Leave(object? sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.White;
        }

        private void Button6_GotFocus(object? sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Orange;
        }

        private void TextBox2_Leave(object? sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
        }

        private void TextBox2_GotFocus(object? sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.Orange;
        }

        /// <summary>
        /// 图片展示
        /// </summary>
        private void PicShow()
        {
            pictureBox1.Image = Image.FromFile(picArr[index]);
            buttonList1.ForEach(btn =>
            {
                btn.BackColor = Color.DarkGray;
                btn.ForeColor = Color.Black;
            });
            buttonList1[index].BackColor = Color.Orange;
            buttonList1[index].ForeColor = Color.White;
        }
        /// <summary>
        /// 按钮1,2,3的点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object? sender, EventArgs e)
        {
            index = buttonList1.IndexOf((sender as Button));
            PicShow();
        }
        /// <summary>
        /// 图片两边按钮轮播处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object? sender, EventArgs e)
        {
            if ((sender as Button).Text == "<")
            {
                index = index == 0 ? picArr.Length - 1 : --index;

            }
            else
                if ((sender as Button).Text == ">")
                {
                    index = index == picArr.Length - 1 ? 0 : ++index;

                }
            PicShow();

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    pictureBox1.Image = Image.FromFile("images/cat.jpg");
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    pictureBox1.Image = Image.FromFile("images/bird.jpg");
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    pictureBox1.Image = Image.FromFile("images/eagle.jpg");
        //}
        /// <summary>
        /// 文本输入框内容改变时label隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            label6.Visible = false;
            label7.Visible = false;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                label1.Visible = false;

            }





        }
        /// <summary>
        /// 文本输入框光标时没有输入内容label显示，光标再次获取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label1.Visible = true;
                textBox1.Focus();
            }
            if (Regex.IsMatch(textBox1.Text, @"^[1][0-9]\d{9}$"))
            {
                label7.Visible = true;
            }
            else
            {
                label6.Visible = true;
            }
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Purple;
            (sender as Label).Font = new Font("Microsoft YaHei UI", 9f, FontStyle.Underline);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {

            (sender as Label).ForeColor = Color.Blue;
            (sender as Label).Font = new Font("Microsoft YaHei UI", 9f, FontStyle.Regular);
        }

        /// <summary>
        /// 获取鼠标在form窗口的坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            MouseX.Text = e.X.ToString();
            MouseY.Text = e.Y.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <'0'||e.KeyChar>'9')
            {
                e.Handled = true;
            }
            
        }
    }
}
