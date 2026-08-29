using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsAppTest8_25.MyCtrls;
namespace WinFormsAppTest8_25
{
    public partial class Form5 : Form
    {
        //模拟数据库
        List<BookClass> bookDateList = new List<BookClass>();

        BookInfo booksList;
        //BookClass books_dateList;
        public Form5()
        {
            InitializeComponent();
            
        }

        private void BooksList_del(string obj)
        {

            bookDateList.RemoveAll(item => item.uid == obj);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uid= Guid.NewGuid().ToString();
            booksList = new BookInfo(bookName_input.Text, authorName_input.Text, price_inputNumber.Text, test_input.Text);
            booksList.del += BooksList_del;
            booksList.Tag = uid;
             bookDateList.Add( new BookClass(uid,bookName_input.Text, authorName_input.Text, price_inputNumber.Text, test_input.Text));
            
            flowLayoutPanel1.Controls.Add(booksList);

            //bookDateList.Add(books_dateList);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bookDateList.Count.ToString());
        }

        

    }
}
