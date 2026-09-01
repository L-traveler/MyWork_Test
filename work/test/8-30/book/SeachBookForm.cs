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
    public partial class SeachBookForm : Form
    {
        public SeachBookForm()
        {
            InitializeComponent();
            ShowBook();
        }

        private void ShowBook()
        { 
            //读取文件数据，向表格里添加数据
            string JsonStr = File.ReadAllText("./book.json");
            List<BookClass> bookList= new List<BookClass>();
             bookList=JsonSerializer.Deserialize<List<BookClass>>(JsonStr);
            table1.DataSource = bookList;

            //重置表头
            table1.Columns.Clear();
            table1.Columns = new AntdUI.ColumnCollection()
            {
                new AntdUI.Column("uid", "编号")
                {
                    Render=(object val,object cel ,int index)=>{return index.ToString(); }

                },
                new AntdUI.Column("bookName","书名"),
                new AntdUI.Column("authorName","作者"),
                new AntdUI.Column("price","价格"),
                new AntdUI.Column("test","标签"),
                new AntdUI.Column("isBorrow", "是否借阅")
                {
                    Render=(object val,object cel,int index )=>{return (bool)val?"已借阅":"书架中"; }
                },
            }; 

        }
    }
}
