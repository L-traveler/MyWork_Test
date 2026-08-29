using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppTest8_25.MyCtrls
{
    public partial class BookInfo : UserControl
    {

        public event Action<string> del;


        public BookInfo()
        {
            InitializeComponent();
        }
        public BookInfo(string bookName, string authorName, string price, string text)
        {
            InitializeComponent();
            label1.Text = bookName;
            label2.Text = authorName;
            label3.Text = price;
            label4.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Parent.Parent.Controls.Remove(button1.Parent);

            del?.Invoke(this.Tag.ToString());
        }
    }
}
