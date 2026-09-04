using WinFormsAppTest9_2.book;

namespace WinFormsAppTest9_2
{
    public partial class Form1 : Form
    {
        private string mask { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
             if (mask == "已登录")
            {
                //跳转图书界面
                var bookshow = new BookShow();
                bookshow.Show();
                
                this.Hide();
                bookshow.FormClosing += Bookshow_FormClosing;
            }
            else 
            {
                //跳转登录界面
                var lg = new Login();
                lg.Show();
                lg.loginMask += Lg_loginMask;
                this.Hide();
                lg.FormClosing += Lg_FormClosing;
            }

        }

        private void Bookshow_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void Lg_loginMask(string obj)
        {
            mask = obj;
            label2.Text = obj;
        }

        private void Lg_FormClosing(object? sender, FormClosingEventArgs e)
        {
           this.Show();
        }
    }
}
