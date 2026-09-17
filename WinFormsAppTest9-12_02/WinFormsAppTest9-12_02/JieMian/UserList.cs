using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsAppTest9_12_02.MySql;

namespace WinFormsAppTest9_12_02.JieMian
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
            this.Shown += UserList_Shown;
        }

        private async void UserList_Shown(object? sender, EventArgs e)
        {
            table1.DataSource= await MySqlHander.SearchAll("user_info");
            UserDataShow();

        }
        private void UserDataShow()
        {
            table1.Columns.Clear();
            table1.Columns = new AntdUI.ColumnCollection()
            {
                new AntdUI.Column("id", "编号")
                {
                    Render = (val,col,index) =>
                    {
                        return index+1;
                    }
                },
                new AntdUI.Column("name","名字"),
                new AntdUI.Column("id_card","身份证号"),
                new AntdUI.Column("reg_time","注册时间"),
                new AntdUI.Column("gender","性别"),
                new AntdUI.Column("tel","联系方式"),
                new AntdUI.Column("motto","座右铭"),

            };

        }
    }
}
