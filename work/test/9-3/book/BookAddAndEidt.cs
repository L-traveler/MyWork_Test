using AntdUI;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsAppTest9_2.Mysql;

namespace WinFormsAppTest9_2.book
{
    public partial class BookAddAndEidt : Form
    {
        private MySql Mysql = new MySql("test01");
        private string Id { get; set; }
        private string Title { get; set; }
        public BookAddAndEidt()
        {
            InitializeComponent();
        }
        //新增
        public BookAddAndEidt(string opt)
        {
            InitializeComponent();
            label1.Text ="图书"+ opt;
            button1.Text = opt;
            this.Title = opt;
        }
        //编辑
        public BookAddAndEidt(string opt, string id)
        {
            InitializeComponent();
            label1.Text ="图书"+ opt;
            button1.Text = opt;
            this.Title = opt;
            this.Id = id;
            // 查询数据并回显(回填到界面)
            ShowBook();

        }

        private async void ShowBook()
        {
            string sql = "select * from book where id = @id";
            await Mysql.ConAndHandler(sql, Cmd =>
            {
                // 参数填充
                Cmd.Parameters.AddWithValue("@id", Id);
                MySqlDataReader Reader = Cmd.ExecuteReader();

                bool IsRead = Reader.Read();
                if (!IsRead)
                {
                    MessageBox.Show("编辑失败!!!");
                    this.Close();
                    return false;
                }
                // Reader读到的数据 回填到窗体中
                bookName_input.Text = Reader.GetString("name");
                authorName_input.Text = Reader.GetString("author");
                // 注意: inputNumber控件的值 必须通过 Value设置  decimal 类型的值
                price_inputNumber.Value = (decimal)Reader.GetDouble("price");
                test_input.Text = Reader.GetString("label").Replace(" | ", "\n");

                return true;
            });


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string Name=bookName_input.Text;
            string Author=authorName_input.Text;
            double Price=(double)price_inputNumber.Value;
            string Booklable = test_input.Text.Replace("\n","|");

            string sql = "";

            if (this.Title == "新增")
            {
                sql = "insert into book(name,author,price,label) value(@name,@author,@price,@label)";
            }
            else
            {
                sql = "update  book set name=@name,author=@author,price=@price,label=@label where id=@id";

            }

            // 数据库操作
            await Mysql.ConAndHandler(sql, cmd =>
            {
                // 填充参数
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@author", Author);
                cmd.Parameters.AddWithValue("@price", Price);
                cmd.Parameters.AddWithValue("@label", Booklable);
                if (this.Title == "编辑") cmd.Parameters.AddWithValue("@id", Id);

                // 执行
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show(this.Title + "成功");
                    this.Close();// 成功则关闭当前窗体
                }
                else
                {
                    MessageBox.Show(this.Title + "失败");
                }

                return true;

            });

        }
    }
}
