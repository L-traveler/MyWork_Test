namespace WinFormsAppTest8_25
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
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button6 = new Button();
            textBox2 = new TextBox();
            MouseY = new Label();
            MouseX = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 197);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(205, 165);
            button3.Name = "button3";
            button3.Size = new Size(31, 36);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(153, 165);
            button2.Name = "button2";
            button2.Size = new Size(31, 36);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(94, 165);
            button1.Name = "button1";
            button1.Size = new Size(31, 36);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button4.Location = new Point(21, 86);
            button4.Name = "button4";
            button4.Size = new Size(23, 59);
            button4.TabIndex = 2;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button5.Location = new Point(310, 86);
            button5.Name = "button5";
            button5.Size = new Size(23, 59);
            button5.TabIndex = 3;
            button5.Text = ">";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 226);
            panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(432, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.Leave += textBox1_Leave;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(420, 121);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(262, 67);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(706, 42);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 7;
            label1.Text = "内容不能为空！";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 263);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 8;
            label2.Text = "原神";
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 395);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 9;
            label3.Text = "鼠标X的坐标：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 421);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 10;
            label4.Text = "鼠标Y的坐标：";
            // 
            // button6
            // 
            button6.Location = new Point(615, 194);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 11;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(420, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 27);
            textBox2.TabIndex = 12;
            // 
            // MouseY
            // 
            MouseY.AutoSize = true;
            MouseY.Location = new Point(106, 421);
            MouseY.Name = "MouseY";
            MouseY.Size = new Size(0, 20);
            MouseY.TabIndex = 14;
            // 
            // MouseX
            // 
            MouseX.AutoSize = true;
            MouseX.Location = new Point(106, 395);
            MouseX.Name = "MouseX";
            MouseX.Size = new Size(0, 20);
            MouseX.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 42);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 15;
            label5.Text = "手机号:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(466, 69);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 16;
            label6.Text = "输入格式有误！";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Green;
            label7.Location = new Point(466, 69);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 17;
            label7.Text = "成功√";
            label7.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownHeight = 60;
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "AA", "BB", "CC", "DD", "EE", "FF", "GG", "HH", "II", "JJ", "KK" });
            comboBox1.Location = new Point(139, 260);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(87, 28);
            comboBox1.TabIndex = 18;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(MouseY);
            Controls.Add(MouseX);
            Controls.Add(textBox2);
            Controls.Add(button6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Name = "Form2";
            Text = "Form2";
            KeyDown += Form2_KeyDown;
            MouseMove += Form2_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel2;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button6;
        private TextBox textBox2;
        private Label MouseY;
        private Label MouseX;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
    }
}