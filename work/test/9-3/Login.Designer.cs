namespace WinFormsAppTest9_2
{
    partial class Login
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
            label4 = new AntdUI.Label();
            button2 = new AntdUI.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(213, 12);
            label1.Name = "label1";
            label1.Size = new Size(249, 73);
            label1.TabIndex = 0;
            label1.Text = "登录";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(201, 91);
            label2.Name = "label2";
            label2.Size = new Size(100, 45);
            label2.TabIndex = 1;
            label2.Text = "用户名：";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input1
            // 
            input1.Location = new Point(307, 80);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入用户名";
            input1.Size = new Size(229, 65);
            input1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(260, 259);
            button1.Name = "button1";
            button1.Size = new Size(167, 55);
            button1.TabIndex = 5;
            button1.Text = "登录";
            button1.Click += button1_Click;
            // 
            // input2
            // 
            input2.Location = new Point(307, 151);
            input2.Name = "input2";
            input2.PasswordChar = '*';
            input2.PlaceholderText = "请输入密码";
            input2.Size = new Size(229, 65);
            input2.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(201, 162);
            label3.Name = "label3";
            label3.Size = new Size(100, 45);
            label3.TabIndex = 3;
            label3.Text = "密码：";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(30, 375);
            label4.Name = "label4";
            label4.Size = new Size(148, 36);
            label4.TabIndex = 6;
            label4.Text = "没有账号请先注册->";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(176, 375);
            button2.Name = "button2";
            button2.Size = new Size(100, 36);
            button2.TabIndex = 7;
            button2.Text = "注册";
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 443);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(input2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(input1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Input input1;
        private AntdUI.Button button1;
        private AntdUI.Input input2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Button button2;
    }
}