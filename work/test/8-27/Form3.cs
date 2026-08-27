using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsAppTest8_25
{
    public partial class Form3 : Form
    {
        
        List<Dictionary<string,Control>> ctrlList = new List<Dictionary<string,Control>>();
        public Form3()
        {
            InitializeComponent();

            InitFrom();
        }

        //先将每行的数据组成一个字典或类放到list里
        //输入框事件触发取出所对应的单价 -相乘
        //遍历-赋值返回

        private void InitFrom()
        {
            ctrlList.Add(new Dictionary<string, Control>
            {
                ["price"] = label1,
                ["count"] = textBox1,
                ["sub"] = button1,
                ["add"] = button2

            });

            ctrlList.Add(new Dictionary<string, Control>
            {
                ["price"] = label2,
                ["count"] = textBox2,
                ["sub"] = button3,
                ["add"] = button4
            });
            //给每个输入框添加事件
            ctrlList.ForEach(ctrl => {
                ctrl["count"].TextChanged += TextBox_TextChanged;
                ctrl["sub"].Click += SubBtn_Click;
                ctrl["add"].Click += AddBtn_Click;
            });

            

        }

        private void AddBtn_Click(object? sender, EventArgs e)
        {
            var dic = ctrlList.Find(item => item["add"] == sender as Button);
            dic["count"].Text = (int.Parse(dic["count"].Text) +1).ToString();

        }

        private void SubBtn_Click(object? sender, EventArgs e)
        {
            //ctrlList.ForEach(item => { item["count"].Text = (int.Parse(item["count"].Text) - 1).ToString(); });
            var dic=ctrlList.Find(item =>  item["sub"] == sender as Button);
            dic["count"].Text=(int.Parse(dic["count"].Text)-1).ToString();

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;
            ctrlList.ForEach(item =>
            {
                if (item["count"].Text.Length>0)
                {
                    if (!Regex.IsMatch(item["count"].Text,@"^[0-9]*$"))
                    {
                        item["count"].Text = "0";
                        (item["count"] as TextBox).SelectionStart = 1;
                    }
                    sum += int.Parse(item["count"].Text) * int.Parse(item["price"].Text);

                }
                

            });
            label4.Text = sum.ToString();
        }
    }
}
