namespace WinFormsAppTest9_2
{
    partial class Form2
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
            label3 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            label6 = new AntdUI.Label();
            label7 = new AntdUI.Label();
            label8 = new AntdUI.Label();
            label9 = new AntdUI.Label();
            button1 = new AntdUI.Button();
            image3d1 = new AntdUI.Image3D();
            button2 = new AntdUI.Button();
            button3 = new AntdUI.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(274, 12);
            label1.Name = "label1";
            label1.Size = new Size(225, 67);
            label1.TabIndex = 0;
            label1.Text = "国庆倒计时";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(134, 150);
            label2.Name = "label2";
            label2.Size = new Size(58, 67);
            label2.TabIndex = 1;
            label2.Text = "";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.Location = new Point(208, 150);
            label3.Name = "label3";
            label3.Size = new Size(58, 67);
            label3.TabIndex = 2;
            label3.Text = "天";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.Location = new Point(272, 150);
            label4.Name = "label4";
            label4.Size = new Size(58, 67);
            label4.TabIndex = 4;
            label4.Text = "";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.Location = new Point(336, 150);
            label5.Name = "label5";
            label5.Size = new Size(58, 67);
            label5.TabIndex = 3;
            label5.Text = "时";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.Location = new Point(400, 150);
            label6.Name = "label6";
            label6.Size = new Size(58, 67);
            label6.TabIndex = 6;
            label6.Text = "";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label7.Location = new Point(455, 150);
            label7.Name = "label7";
            label7.Size = new Size(58, 67);
            label7.TabIndex = 5;
            label7.Text = "分";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label8.Location = new Point(519, 150);
            label8.Name = "label8";
            label8.Size = new Size(58, 67);
            label8.TabIndex = 8;
            label8.Text = "";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label9.Location = new Point(583, 150);
            label9.Name = "label9";
            label9.Size = new Size(58, 67);
            label9.TabIndex = 7;
            label9.Text = "秒";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(12, 218);
            button1.Name = "button1";
            button1.Size = new Size(73, 40);
            button1.TabIndex = 9;
            button1.Text = "选择文件";
            button1.Click += button1_Click;
            // 
            // image3d1
            // 
            image3d1.ImageFit = AntdUI.TFit.Contain;
            image3d1.Location = new Point(108, 223);
            image3d1.Name = "image3d1";
            image3d1.Size = new Size(222, 175);
            image3d1.TabIndex = 10;
            image3d1.Text = "image3d1";
            // 
            // button2
            // 
            button2.Location = new Point(336, 243);
            button2.Name = "button2";
            button2.Size = new Size(73, 40);
            button2.TabIndex = 11;
            button2.Text = "保存文件";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(336, 302);
            button3.Name = "button3";
            button3.Size = new Size(73, 40);
            button3.TabIndex = 12;
            button3.Text = "打开文件夹";
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(image3d1);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.Label label6;
        private AntdUI.Label label7;
        private AntdUI.Label label8;
        private AntdUI.Label label9;
        private AntdUI.Button button1;
        private AntdUI.Image3D image3d1;
        private AntdUI.Button button2;
        private AntdUI.Button button3;
    }
}