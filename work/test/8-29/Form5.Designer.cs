namespace WinFormsAppTest8_25
{
    partial class Form5
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
            bookName_input = new AntdUI.Input();
            authorName_input = new AntdUI.Input();
            label3 = new AntdUI.Label();
            test_input = new AntdUI.Input();
            label4 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            price_inputNumber = new AntdUI.InputNumber();
            button1 = new AntdUI.Button();
            flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            button2 = new AntdUI.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(256, 26);
            label1.Name = "label1";
            label1.Size = new Size(143, 35);
            label1.TabIndex = 0;
            label1.Text = "图书新增";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(104, 85);
            label2.Name = "label2";
            label2.Size = new Size(106, 36);
            label2.TabIndex = 1;
            label2.Text = "图书名称：";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bookName_input
            // 
            bookName_input.Location = new Point(228, 76);
            bookName_input.Name = "bookName_input";
            bookName_input.PlaceholderColorExtend = "";
            bookName_input.PlaceholderText = "请输入图书名称";
            bookName_input.Size = new Size(212, 54);
            bookName_input.TabIndex = 2;
            // 
            // authorName_input
            // 
            authorName_input.Location = new Point(228, 136);
            authorName_input.Name = "authorName_input";
            authorName_input.PlaceholderColorExtend = "";
            authorName_input.PlaceholderText = "请输入作者姓名";
            authorName_input.Size = new Size(212, 54);
            authorName_input.TabIndex = 4;
            // 
            // label3
            // 
            label3.Location = new Point(104, 145);
            label3.Name = "label3";
            label3.Size = new Size(106, 36);
            label3.TabIndex = 3;
            label3.Text = "作者：";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // test_input
            // 
            test_input.Location = new Point(228, 256);
            test_input.Multiline = true;
            test_input.Name = "test_input";
            test_input.PlaceholderColorExtend = "";
            test_input.PlaceholderText = "请输入图书名称";
            test_input.Size = new Size(212, 149);
            test_input.TabIndex = 6;
            // 
            // label4
            // 
            label4.Location = new Point(104, 265);
            label4.Name = "label4";
            label4.Size = new Size(106, 36);
            label4.TabIndex = 5;
            label4.Text = "标签：";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(104, 205);
            label5.Name = "label5";
            label5.Size = new Size(106, 36);
            label5.TabIndex = 7;
            label5.Text = "价格：";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // price_inputNumber
            // 
            price_inputNumber.Location = new Point(228, 196);
            price_inputNumber.Name = "price_inputNumber";
            price_inputNumber.PlaceholderText = "0";
            price_inputNumber.Size = new Size(212, 54);
            price_inputNumber.TabIndex = 8;
            price_inputNumber.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(228, 411);
            button1.Name = "button1";
            button1.Size = new Size(212, 52);
            button1.TabIndex = 9;
            button1.Text = "新增";
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(461, 43);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(336, 420);
            flowLayoutPanel1.TabIndex = 10;
            flowLayoutPanel1.Text = "flowLayoutPanel1";
            flowLayoutPanel1.WrapContents = false;
            // 
            // button2
            // 
            button2.Location = new Point(79, 416);
            button2.Name = "button2";
            button2.Size = new Size(92, 36);
            button2.TabIndex = 11;
            button2.Text = "button2";
            button2.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 484);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(price_inputNumber);
            Controls.Add(label5);
            Controls.Add(test_input);
            Controls.Add(label4);
            Controls.Add(authorName_input);
            Controls.Add(label3);
            Controls.Add(bookName_input);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Input bookName_input;
        private AntdUI.Input authorName_input;
        private AntdUI.Label label3;
        private AntdUI.Input test_input;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.InputNumber price_inputNumber;
        private AntdUI.Button button1;
        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
        private AntdUI.Button button2;
    }
}