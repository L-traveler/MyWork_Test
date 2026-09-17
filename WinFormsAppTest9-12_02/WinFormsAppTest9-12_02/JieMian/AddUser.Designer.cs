namespace WinFormsAppTest9_12_02.JieMian
{
    partial class AddUser
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
            button1 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(282, 308);
            button1.Name = "button1";
            button1.Size = new Size(173, 52);
            button1.TabIndex = 15;
            button1.Text = "添加";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(314, 181);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 27);
            textBox3.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(194, 181);
            label4.Name = "label4";
            label4.Size = new Size(72, 27);
            label4.TabIndex = 13;
            label4.Text = "性别：";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(314, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(194, 148);
            label3.Name = "label3";
            label3.Size = new Size(112, 27);
            label3.TabIndex = 11;
            label3.Text = "身份证号：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(314, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(194, 115);
            label2.Name = "label2";
            label2.Size = new Size(72, 27);
            label2.TabIndex = 9;
            label2.Text = "姓名：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(270, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 37);
            label1.TabIndex = 8;
            label1.Text = "客户新增界面";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(314, 214);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(187, 27);
            textBox4.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(194, 214);
            label5.Name = "label5";
            label5.Size = new Size(92, 27);
            label5.TabIndex = 16;
            label5.Text = "手机号：";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(314, 247);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(187, 27);
            textBox5.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.Location = new Point(194, 247);
            label6.Name = "label6";
            label6.Size = new Size(92, 27);
            label6.TabIndex = 18;
            label6.Text = "座右铭：";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 453);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddUser";
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
    }
}