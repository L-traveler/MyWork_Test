using AntdUI;
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
    public partial class DelBookForm : Form
    {
        BookInfo bookInfo;
        
        public DelBookForm()
        {
            InitializeComponent();
            InitDel();
        }

        private void InitDel()
        {

            //读取文件数据，向表格里添加数据
            string JsonStr = File.ReadAllText("./book.json");
            List<BookClass> bookList = new List<BookClass>();
            bookList = JsonSerializer.Deserialize<List<BookClass>>(JsonStr);
            bookList.ForEach(item =>
            {
                bookInfo = new BookInfo(item.bookName, item.authorName, item.price, item.test);
                bookInfo.del += BookInfo_del;
                bookInfo.Tag= item.uid;
                flowLayoutPanel1.Controls.Add(bookInfo);
                
            });
            var newJsonStr = JsonSerializer.Serialize(bookList, new JsonSerializerOptions()
            {
                AllowDuplicateProperties = true,
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            File.WriteAllText("./book.json", newJsonStr);



        }

        private void BookInfo_del(string obj)
        {
            //读取文件数据，向表格里添加数据
            string JsonStr = File.ReadAllText("./book.json");
            List<BookClass> bookList = new List<BookClass>();
            bookList = JsonSerializer.Deserialize<List<BookClass>>(JsonStr);

            bookList.RemoveAll(item => item.uid == obj);

            var newJsonStr = JsonSerializer.Serialize(bookList, new JsonSerializerOptions()
            {
                AllowDuplicateProperties = true,
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            File.WriteAllText("./book.json", newJsonStr);
        }
    }
}
