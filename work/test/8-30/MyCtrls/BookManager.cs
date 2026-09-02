using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppTest8_25.MyCtrls
{
    public partial class BookManager : UserControl
    {
        string id=Guid.NewGuid().ToString();
        internal event Action<BookClass> addBook;
        internal event Action<BookClass> editBook;
        public BookManager()
        {
            InitializeComponent();

        }
        public BookManager(string name)
        {
            InitializeComponent();
            button1.Text = name;
            label1.Text += name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            addBook.Invoke(new BookClass(id,bookName_input.Text,authorName_input.Text,price_inputNumber.Text,test_input.Text));

        }

    }
}
