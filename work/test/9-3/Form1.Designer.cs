namespace WinFormsAppTest9_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new AntdUI.Label();
            button1 = new AntdUI.Button();
            button2 = new AntdUI.Button();
            label2 = new AntdUI.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(257, 12);
            label1.Name = "label1";
            label1.Size = new Size(193, 65);
            label1.TabIndex = 0;
            label1.Text = "目录";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(34, 126);
            button1.Name = "button1";
            button1.Size = new Size(169, 62);
            button1.TabIndex = 1;
            button1.Text = "图书管理系统";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button2.Location = new Point(34, 240);
            button2.Name = "button2";
            button2.Size = new Size(169, 62);
            button2.TabIndex = 2;
            button2.Text = "汽车租还系统";
            // 
            // label2
            // 
            label2.Location = new Point(209, 163);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 3;
            label2.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 433);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Label label2;
    }
}
