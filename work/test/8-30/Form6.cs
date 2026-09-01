using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsAppTest8_25.book;

namespace WinFormsAppTest8_25
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            new AddBookForm().ShowDialog();
        }

        private void editBookBtn_Click(object sender, EventArgs e)
        {
            new EditBookForm().ShowDialog();
        }

        private void delBookBtn_Click(object sender, EventArgs e)
        {
            new DelBookForm().ShowDialog();
        }

        private void seachBookBtn_Click(object sender, EventArgs e)
        {
            new SeachBookForm().ShowDialog();
        }
    }
}
