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

            var timer=new System.Windows.Forms.Timer();
            timer.Interval=1000;
            timer.Tick += (sender,e) => { ShowTime(); };
            timer.Start();
            ShowTime();
        }

        private void ShowTime()
        {
            var res=DateTime.Parse("2026-10-01 00:00:00")-DateTime.Now ;
            var day = Math.Floor( res.TotalDays);
            var hour = res.Hours%24;
            var minute = res.Minutes%60;
            var seconds = res.Seconds%60;
            label2.Text=day.ToString();
            label4.Text= hour.ToString();
            label6.Text= minute.ToString();
            label8.Text= seconds.ToString();
        }
    }
}
