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
    public partial class RetList : Form
    {
        public RetList()
        {
            InitializeComponent();
            this.Shown += RetList_Shown;
        }

        private async void RetList_Shown(object? sender, EventArgs e)
        {
            table1.DataSource= await MySqlHander.SearchAll("rent_return");
            retDataShow();
        }
        private void retDataShow()
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
                new AntdUI.Column("car_id","汽车编号"),
                new AntdUI.Column("user_id","用户编号"),
                new AntdUI.Column("rent_time","租车时间"),
                new AntdUI.Column("return_time","还车时间"),
                new AntdUI.Column("pay_money","需付金额"),
               

            };

        }
    }
}
