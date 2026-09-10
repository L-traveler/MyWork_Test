namespace WinFormsAppTest9_10
{
    partial class DaiModBus
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
            button2 = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(184, 379);
            button2.Name = "button2";
            button2.Size = new Size(123, 43);
            button2.TabIndex = 7;
            button2.Text = "改转速";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 336);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Location = new Point(383, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 412);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(28, 39);
            button1.Name = "button1";
            button1.Size = new Size(116, 45);
            button1.TabIndex = 4;
            button1.Text = "打开串口";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(28, 133);
            button3.Name = "button3";
            button3.Size = new Size(123, 43);
            button3.TabIndex = 8;
            button3.Text = "启动";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(184, 133);
            button4.Name = "button4";
            button4.Size = new Size(123, 43);
            button4.TabIndex = 9;
            button4.Text = "停止";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(28, 207);
            button5.Name = "button5";
            button5.Size = new Size(123, 43);
            button5.TabIndex = 10;
            button5.Text = "改正向";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(184, 207);
            button6.Name = "button6";
            button6.Size = new Size(123, 43);
            button6.TabIndex = 11;
            button6.Text = "改反向";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // DaiModBus
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "DaiModBus";
            Text = "DaiModBus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox1;
        private Panel panel1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}