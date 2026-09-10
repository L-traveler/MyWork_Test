namespace WinFormsAppTest9_9
{
    partial class MyTcpClient
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
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 27);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 15;
            label3.Text = "消息：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 265);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 12;
            label2.Text = "消息：";
            // 
            // button2
            // 
            button2.Location = new Point(144, 164);
            button2.Name = "button2";
            button2.Size = new Size(79, 35);
            button2.TabIndex = 11;
            button2.Text = "断开连接";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(126, 27);
            textBox2.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Location = new Point(448, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 376);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 102);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 8;
            label1.Text = "端口：";
            // 
            // button1
            // 
            button1.Location = new Point(31, 164);
            button1.Name = "button1";
            button1.Size = new Size(79, 35);
            button1.TabIndex = 16;
            button1.Text = "连接Tcp";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 27);
            textBox1.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 53);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 17;
            label4.Text = "IP：";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(97, 262);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(126, 27);
            textBox3.TabIndex = 19;
            // 
            // button3
            // 
            button3.Location = new Point(130, 319);
            button3.Name = "button3";
            button3.Size = new Size(79, 35);
            button3.TabIndex = 20;
            button3.Text = "发送";
            button3.UseVisualStyleBackColor = true;
            // 
            // MyTcpClient
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "MyTcpClient";
            Text = "MyTcpClient01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox3;
        private Button button3;
    }
}