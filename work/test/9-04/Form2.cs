using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppTest9_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => { ShowTime(); };
            timer.Start();
            ShowTime();
        }

        private void ShowTime()
        {
            var res = DateTime.Parse("2026-10-01 00:00:00") - DateTime.Now;
            var day = Math.Floor(res.TotalDays);
            var hour = res.Hours % 24;
            var minute = res.Minutes % 60;
            var seconds = res.Seconds % 60;
            label2.Text = day.ToString();
            label4.Text = hour.ToString();
            label6.Text = minute.ToString();
            label8.Text = seconds.ToString();
        }
        //选择文件按钮
        private void button1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                string filePath;
                OFD.Title = "请选择文件";
                OFD.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
                OFD.FilterIndex = 2;

                OFD.RestoreDirectory = true;
                //OFD.InitialDirectory = Application.StartupPath;
                //OFD.ShowDialog();
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    // 获取选中文件完整路径
                    filePath = OFD.FileName;
                    MessageBox.Show("你选中的文件：" + filePath);
                    // 有了文件路径后，如果是文本文件可以读取，图片可以设置在PictureBox中
                }

                image3d1.Image = Image.FromFile(OFD.FileName);
            }

        }

        //保存
        private void button2_Click(object sender, EventArgs e)
        {
            using (var OFD = new SaveFileDialog())
            {
                OFD.Title = "保存文件";
                OFD.InitialDirectory = Application.StartupPath;
                OFD.Filter = "文本|*.txt";
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(OFD.FileName, "fsdf");
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var DBD =new System.Windows.Forms.FolderBrowserDialog())
            {
                DBD.Description = "请选择文件夹";

                if (DBD.ShowDialog()==DialogResult.OK)
                {
                    MessageBox.Show(DBD.SelectedPath);
                }
            }
        }
    }
}
