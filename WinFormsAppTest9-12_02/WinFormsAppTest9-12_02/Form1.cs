using AntdUI;
using WinFormsAppTest9_12_02.JieMian;
using WinFormsAppTest9_12_02.MySql;

namespace WinFormsAppTest9_12_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        private async void Form1_Shown(object? sender, EventArgs e)
        {
            CarDataShow();
        }

        //新增车辆
        private void button1_Click(object sender, EventArgs e)
        {
            //跳转
            var addCar = new AddCar();
            addCar.Show();
            addCar.FormClosing += (s, e) => { this.Show(); CarDataShow(); };
            this.Hide();

        }
        //新增客户
        private void button2_Click(object sender, EventArgs e)
        {
            //跳转
            var addUser = new AddUser();
            addUser.Show();
            addUser.FormClosing += (s, e) => { this.Show(); };
            this.Hide();
        }

        //客户展示按钮
        private async void button3_Click(object sender, EventArgs e)
        {
            //跳转
            var UserShow = new UserList();
            UserShow.Show();
            UserShow.FormClosing += (s, e) => { this.Show(); 
            };
            this.Hide();

        }
        private async void CarDataShow()
        {
            table1.CellButtonClick -= Table1_CellButtonClick;
            table1.DataSource = await MySqlHander.SearchAll("car");
            SetTableCol();
            
           
        }

        private  void SetTableCol()
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
                new AntdUI.Column("card","车牌号"),
                new AntdUI.Column("type","车类型"),
                new AntdUI.Column("status", "是否借出")
                {
                     Render = (object val,object col,int index) =>
                    {
                        return val.ToString()=="1"?"空闲":"已借出";
                    }
                },
                new AntdUI.Column("price","时费"),
                
            };

            AntdUI.Column handlerCol = new AntdUI.Column("handler", "操作")
            {
                Render = (object val, object col, int index) =>
                {
                    var _btns = new AntdUI.CellLink[] {
                       
                        new AntdUI.CellButton("resort", "租车", AntdUI.TTypeMini.Default)
                   };
                    return _btns;

                }
            };

            table1.Columns.Add(handlerCol);


            //绑定事件

            //租还
            table1.CellButtonClick += Table1_CellButtonClick;
           
        }

        private void Table1_CellButtonClick(object sender, TableButtonEventArgs e)
        {

            //获取点击按钮的行数据
            var row = e.Record as System.Data.DataRow;
            if (row == null) return; //判空，防止null报错


            Properties.Settings.Default.card = row["card"]?.ToString();   //车牌号
            Properties.Settings.Default.type = row["type"]?.ToString();   //车类型
            Properties.Settings.Default.cardId= row["id"]?.ToString();   //车编号

            //e.Btn点击触发的按钮
            if (e.Btn.Text == "租车")
            {

                //if (row["status"].ToString()=="已出租")
                //if (row["status"].ToString()=="已借出")
                if (row["status"].ToString() == "0")
                {
                    MessageBox.Show("该车已出租");
                    return;
                }
                var retFrom = new ZuHuan();

                retFrom.Show();
                retFrom.FormClosing += (s, e) => {
                    this.Show(); CarDataShow();
                };
                this.Hide();

            }
        }

        //租车记录按钮
        private void button4_Click(object sender, EventArgs e)
        {
            //跳转
            var RetLog = new RetList();
            RetLog.Show();
            RetLog.FormClosing += (s, e) => { this.Show(); };
            this.Hide();
        }
    }
}
