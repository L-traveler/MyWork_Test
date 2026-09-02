using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using WinFormsAppTest8_25.MyCtrls;

namespace WinFormsAppTest8_25.book
{
    public partial class EditBookForm : Form
    {
        List<BookClass> bookList=new List<BookClass>();
        BookManager bm=new BookManager();
        public EditBookForm()
        {
            InitializeComponent();
            bookManager1.addBook += BookManager1_addBook;
        }

        private void BookManager1_addBook(BookClass book)
        {
            if (File.Exists("./book.json"))
            {
                var jsonStr = File.ReadAllText("book.json");
                bookList = JsonSerializer.Deserialize<List<BookClass>>(jsonStr);
            }

            foreach (var item in bookList)
            {
                if (book.bookName == item.bookName)
                {
                    item.authorName= book.authorName;
                    item.price= book.price;
                    item.test= book.test;
                }
                var newJsonStr = JsonSerializer.Serialize(bookList, new JsonSerializerOptions()
                {
                    WriteIndented = true,
                    AllowDuplicateProperties = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                });
                File.WriteAllText("./book.json", newJsonStr);
                MessageBox.Show("编辑成功");
            }




        }

        
    }
}
