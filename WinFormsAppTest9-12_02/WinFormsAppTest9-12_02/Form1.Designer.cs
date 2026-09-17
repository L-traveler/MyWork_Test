namespace WinFormsAppTest9_12_02
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            table1 = new AntdUI.Table();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(326, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 50);
            label1.TabIndex = 0;
            label1.Text = "车辆租还系统";
            // 
            // button1
            // 
            button1.Location = new Point(33, 97);
            button1.Name = "button1";
            button1.Size = new Size(123, 51);
            button1.TabIndex = 1;
            button1.Text = "新增车辆";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(207, 97);
            button2.Name = "button2";
            button2.Size = new Size(123, 51);
            button2.TabIndex = 2;
            button2.Text = "新增客户";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(385, 97);
            button3.Name = "button3";
            button3.Size = new Size(123, 51);
            button3.TabIndex = 3;
            button3.Text = "客户信息展示";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(552, 97);
            button4.Name = "button4";
            button4.Size = new Size(123, 51);
            button4.TabIndex = 4;
            button4.Text = "租车记录";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // table1
            // 
            table1.Gap = 12;
            table1.Location = new Point(12, 160);
            table1.Name = "table1";
            table1.Size = new Size(711, 398);
            table1.TabIndex = 6;
            table1.Text = "table1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 570);
            Controls.Add(table1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "车辆租还系统";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private AntdUI.Table table1;
    }
}
