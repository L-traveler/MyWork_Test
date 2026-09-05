using WinFormsAppTest9_2.book;

namespace WinFormsAppTest9_2
{
    public partial class Form1 : Form
    {
        private string mask { get; set; }
        public Form1()
        {
            InitializeComponent();

            登录ToolStripMenuItem.Visible = true;
            退出ToolStripMenuItem.Visible = false;
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
                MessageBox.Show("未登录，请点击左上角登录");
            }

        }

        private void Bookshow_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void Lg_loginMask(string obj)
        {
            mask = obj;

        }

        private void Lg_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (mask == "已登录")
            {
                状态ToolStripMenuItem.Text = "已登录";
                登录ToolStripMenuItem.Visible = false;
                退出ToolStripMenuItem.Visible = true;
            }
            this.Show();

        }

        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //跳转登录界面
            var lg = new Login();
            lg.Show();
            lg.loginMask += Lg_loginMask;
            this.Hide();
            lg.FormClosing += Lg_FormClosing;
        }

        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //跳转登录界面
            var rg = new Register();
            rg.Show();

            this.Hide();
            rg.FormClosing += (sender, e) => { this.Show(); };
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mask = "未登录";
            状态ToolStripMenuItem.Text = "未登录";
            登录ToolStripMenuItem.Visible = true;
            退出ToolStripMenuItem.Visible = false;
            MessageBox.Show("退出成功");
        }
    }
}
