namespace WinFormsAppTest9_10
{
    partial class MyPort
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
            button1 = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(44, 47);
            button1.Name = "button1";
            button1.Size = new Size(116, 45);
            button1.TabIndex = 0;
            button1.Text = "打开串口";
            button1.UseVisualStyleBackColor = true;
            //button1.Click += this.button1_Click_1;
            // 
            // panel1
            // 
            panel1.Location = new Point(399, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 412);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 215);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(151, 271);
            button2.Name = "button2";
            button2.Size = new Size(123, 43);
            button2.TabIndex = 3;
            button2.Text = "发送";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.SendData;
            // 
            // MyPort
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "MyPort";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private TextBox textBox1;
        private Button button2;
    }
}
