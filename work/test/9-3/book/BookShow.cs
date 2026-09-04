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
    
    public partial class BookShow : Form
    {
        private MySql mysql = new MySql("test01");
        public BookShow()
        {
            InitializeComponent();
            BookDataShow();
            table1.CellButtonClick += Table1_CellButtonClick;
        }
        //新增按钮
        private void button1_Click(object sender, EventArgs e)
        {
            var addbook = new BookAddAndEidt("新增");
            addbook.Show();
            this.Hide();
            addbook.FormClosing += (sender, e) =>
            {
                this.Show();
                BookDataShow();
            };
            
        }
        //书籍数据table展示
        private async void BookDataShow()
        {
            string sql = "select * from book";

            await mysql.ConAndHandler(sql, cmd =>
            {
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                table1.DataSource = dt;
                SetBookDataTableCol();
               
                return true;

            });
        }

        private void Table1_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            //获取点击按钮的行数据
            var book = e.Record as System.Data.DataRow;
            //e.Btn点击触发的按钮
            if (e.Btn.Text == "编辑")
            {
                var BE = new BookAddAndEidt("编辑", book["id"].ToString());

                BE.Show();
                this.Hide();
                BE.FormClosing += (sender, e) =>
                {
                    this.Show();
                    BookDataShow();
                };

            }

            else if (e.Btn.Text=="删除")
            {
                Del(book["id"].ToString());
            }
            else if (e.Btn.Text=="借书"|| e.Btn.Text == "还书")
            {
                BorrowAndReturn(e.Btn.Text, book["id"].ToString(), book["is_borrow"].ToString()); // 借还书
            }

        }

        //设置table的表头
        private void SetBookDataTableCol()
        {
            table1.Columns.Clear();
            table1.Columns = new AntdUI.ColumnCollection()
            {
                new AntdUI.Column("id","编号"){
                    Render = (object val,object col,int index) =>
                    {
                        return index+1;
                    }

                },
                new AntdUI.Column("name","书名"),
                new AntdUI.Column("author","作者"),
                new AntdUI.Column("price","价格"),
                new AntdUI.Column("label","标签"),
                new AntdUI.Column("is_borrow", "是否借阅")
                {
                    Render = (object val,object col,int index) =>
                    {
                        return val.ToString()=="1"?"已借阅":"在书架中";
                    }
                }
            };

            AntdUI.Column handlerCol = new AntdUI.Column("handler", "操作")
            {
                Render = (object val, object col, int index) =>
                {
                    var _btns = new AntdUI.CellLink[] {
                        new AntdUI.CellButton("edit", "编辑", AntdUI.TTypeMini.Default),
                        new AntdUI.CellButton("delete", "删除", AntdUI.TTypeMini.Default)
                   };
                    return _btns;

                }
            };

            table1.Columns.Add(handlerCol);
            var RetHandlerCol = new AntdUI.Column("resort", "借还书");
            RetHandlerCol.SetAlign();
            RetHandlerCol.Render = (object val, object cel, int index) =>
            {
                return new AntdUI.CellLink[] {
                        new AntdUI.CellButton("borrow", "借书", AntdUI.TTypeMini.Default),
                        new AntdUI.CellButton("return", "还书", AntdUI.TTypeMini.Default)
                   };

            };
            table1.Columns.Add(RetHandlerCol);

        }

        //删除
        private async void Del(string id)
        {
           DialogResult res= MessageBox.Show("确定要删除吗?","删除",MessageBoxButtons.YesNo);
            if (res==DialogResult.No)
            {
                return;
            }
            string sql = "delete from book where id=@id";
            
            await mysql.ConAndHandler(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@id", id);
                int row=cmd.ExecuteNonQuery();
                if (row>0)
                {
                    MessageBox.Show("删除成功");
                    BookDataShow();
                }
                else
                {
                    MessageBox.Show("删除失败！！！");
                    
                }
                return true;
            });


        }
        //借还
        private async  void BorrowAndReturn(string opt,string id,string state)
        {
            // 判断不能操作数据库的情况
            if (opt == "借书" && state == "1")
            {
                MessageBox.Show("书已借出");
                return;
            }
            if (opt == "还书" && state == "2")
            {
                MessageBox.Show("书在书架");
                return;
            }


            // 无论借书 还书 sql语句都一样
            string sql = "update book set is_borrow=@is_borrow where id = @id";
            MySql mySql = new MySql("test01");
            await mySql.ConAndHandler(sql, cmd =>
            {
                // 参数替换
                cmd.Parameters.AddWithValue("@id", id);
                string isBorrow = state == "1" ? "2" : "1";//通过判断获取 要求改的 is_borrow的值
                cmd.Parameters.AddWithValue("@is_borrow", isBorrow);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show(opt + "成功");
                    BookDataShow();
                }
                else
                {
                    MessageBox.Show(opt + "失败");
                }
                return true;

            });
        }
    }
}
