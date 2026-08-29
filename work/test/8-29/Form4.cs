using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppTest8_25
{
    
    public partial class Form4 : Form
    {
        private int x;
        private int y;
        List<Area> areaList = new List<Area>() {
            new Area(1,"广东省",0),
            new Area(2,"广州市",1),
            new Area(3,"深圳市",1),
            new Area(4,"河北省",0),
            new Area(5,"石家庄市",4),
            new Area(6,"邢台市",4),
            new Area(7,"邯郸市",4),
            new Area(8,"唐山市",4),
        };

        Dictionary<string, string[]> areaDic = new Dictionary<string, string[]>();
        public Form4()
        {
            InitializeComponent();

            InitFrom();
            InitFrom2();
            InitButton();
        }

        private void InitButton()
        {
            button1.MouseDown += button1_MouseDown;

            button1.MouseMove += button1_MouseMove;
            button1.MouseUp += button1_MouseUp;
            button2.MouseDown += button2_MouseDown;

           
            button2.MouseUp += button2_MouseUp;


        }

        private void button2_MouseUp(object? sender, MouseEventArgs e)
        {
            button2.MouseMove -= button2_MouseMove;
        }

        private void button2_MouseMove(object? sender, MouseEventArgs e)
        {
            button2.Location=new Point(e.X-x+button2.Location.X,e.Y-y+button2.Location.Y);
            label3.Text = e.X.ToString();
            label4.Text = x.ToString();
            label5.Text = button2.Location.X.ToString();
        }

        private void button2_MouseDown(object? sender, MouseEventArgs e)
        {
            button2.MouseMove += button2_MouseMove;
             x=e.X;
             y=e.Y;
        }

        private Point mouseOffset;
        private bool isDragging = false;

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                // 按钮内部鼠标坐标：鼠标点 - 按钮左上角
                mouseOffset = e.Location;
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // 获取鼠标相对于窗体的屏幕坐标，换算成窗体内部位置
                Point formPoint = button1.Parent.PointToClient(Cursor.Position);
                button1.Location = new Point(formPoint.X - mouseOffset.X, formPoint.Y - mouseOffset.Y);
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void InitFrom2()
        {

            areaDic = new Dictionary<string, string[]>
            {
                ["广东省"] = ["深圳市", "广州市"],
                ["河北省"] = ["石家庄市", "保定市"],
            };
            comboBox3.Text = "请选择省";
            comboBox4.Text = "请选择城市";

            var Pdic = areaDic.Keys;
            //var PNamelist = PList.Select(item => item.Name);
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(Pdic.ToArray());
            comboBox3.SelectedIndexChanged += ComboBox3_SelectedIndexChanged;


        }

        private void ComboBox3_SelectedIndexChanged(object? sender, EventArgs e)
        {
            comboBox4.Text = "请选择城市";
            var pStr = comboBox3.Text;
            var pArea = areaDic[pStr];
            //var cArea = areaList.FindAll(item => item.FatherId == pArea.Id);
            //var cNameArea = cArea.Select(item => item.Name);
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(pArea.ToArray());
        }

        private void InitFrom()
        {
            //初始化两个框的内容分别是请选择省和市
            //第一个下拉框文本为省（父级编号是0的）,下拉框被选后触发事件，第二个下拉框文本为（父级编号是第一个下拉框的id的市）

            comboBox1.Text = "请选择省";
            comboBox2.Text = "请选择城市";
            var PList = areaList.FindAll(item => item.FatherId == 0);
            var PNamelist = PList.Select(item => item.Name);
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(PNamelist.ToArray());
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

        }

        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            comboBox2.Text = "请选择城市";
            var pStr = comboBox1.Text;
            var pArea = areaList.Find(item => item.Name == pStr);
            var cArea = areaList.FindAll(item => item.FatherId == pArea.Id);
            var cNameArea = cArea.Select(item => item.Name);
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(cNameArea.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
