namespace WinFormsAppTest9_2
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            input1 = new AntdUI.Input();
            button1 = new AntdUI.Button();
            input2 = new AntdUI.Input();
            label3 = new AntdUI.Label();
            input3 = new AntdUI.Input();
            label4 = new AntdUI.Label();
            input4 = new AntdUI.Input();
            label5 = new AntdUI.Label();
            label6 = new AntdUI.Label();
            label7 = new AntdUI.Label();
            radio1 = new AntdUI.Radio();
            radio2 = new AntdUI.Radio();
            panel1 = new AntdUI.Panel();
            select1 = new AntdUI.Select();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(280, 12);
            label1.Name = "label1";
            label1.Size = new Size(134, 39);
            label1.TabIndex = 0;
            label1.Text = "注册";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(151, 73);
            label2.Name = "label2";
            label2.Size = new Size(114, 53);
            label2.TabIndex = 1;
            label2.Text = "用户名：";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input1
            // 
            input1.Location = new Point(271, 73);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入用户名（名字）";
            input1.Size = new Size(227, 49);
            input1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(547, 354);
            button1.Name = "button1";
            button1.Size = new Size(143, 67);
            button1.TabIndex = 3;
            button1.Text = "注册";
            button1.Click += button1_Click;
            // 
            // input2
            // 
            input2.Location = new Point(271, 128);
            input2.Name = "input2";
            input2.PasswordChar = '*';
            input2.PlaceholderText = "请输入密码";
            input2.Size = new Size(227, 49);
            input2.TabIndex = 5;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(151, 128);
            label3.Name = "label3";
            label3.Size = new Size(114, 53);
            label3.TabIndex = 4;
            label3.Text = "密码：";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input3
            // 
            input3.Location = new Point(271, 187);
            input3.Name = "input3";
            input3.PasswordChar = '*';
            input3.PlaceholderText = "再次输入密码";
            input3.Size = new Size(227, 49);
            input3.TabIndex = 7;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(151, 187);
            label4.Name = "label4";
            label4.Size = new Size(114, 53);
            label4.TabIndex = 6;
            label4.Text = "确认密码：";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input4
            // 
            input4.Location = new Point(271, 242);
            input4.Name = "input4";
            input4.PlaceholderText = "请输入年龄";
            input4.Size = new Size(227, 49);
            input4.TabIndex = 9;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(151, 242);
            label5.Name = "label5";
            label5.Size = new Size(114, 53);
            label5.TabIndex = 8;
            label5.Text = "年龄：";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.Location = new Point(151, 297);
            label6.Name = "label6";
            label6.Size = new Size(114, 53);
            label6.TabIndex = 10;
            label6.Text = "班级：";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label7.Location = new Point(151, 354);
            label7.Name = "label7";
            label7.Size = new Size(114, 53);
            label7.TabIndex = 12;
            label7.Text = "性别：";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radio1
            // 
            radio1.Checked = true;
            radio1.Location = new Point(0, 0);
            radio1.Name = "radio1";
            radio1.Size = new Size(104, 30);
            radio1.TabIndex = 13;
            radio1.Text = "男";
            // 
            // radio2
            // 
            radio2.Location = new Point(103, 0);
            radio2.Name = "radio2";
            radio2.Size = new Size(101, 30);
            radio2.TabIndex = 14;
            radio2.Text = "女";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(radio1);
            panel1.Controls.Add(radio2);
            panel1.Location = new Point(280, 365);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 30);
            panel1.TabIndex = 15;
            panel1.Text = "panel1";
            // 
            // select1
            // 
            select1.Items.AddRange(new object[] { "01班", "02班", "03班", "04班", "05班" });
            select1.Location = new Point(271, 297);
            select1.Name = "select1";
            select1.PlaceholderText = "请选择你的班级";
            select1.Size = new Size(227, 53);
            select1.TabIndex = 16;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 433);
            Controls.Add(select1);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(input4);
            Controls.Add(label5);
            Controls.Add(input3);
            Controls.Add(label4);
            Controls.Add(input2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(input1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Input input1;
        private AntdUI.Button button1;
        private AntdUI.Input input2;
        private AntdUI.Label label3;
        private AntdUI.Input input3;
        private AntdUI.Label label4;
        private AntdUI.Input input4;
        private AntdUI.Label label5;
        private AntdUI.Label label6;
        private AntdUI.Label label7;
        private AntdUI.Radio radio1;
        private AntdUI.Radio radio2;
        private AntdUI.Panel panel1;
        private AntdUI.Select select1;
    }
}