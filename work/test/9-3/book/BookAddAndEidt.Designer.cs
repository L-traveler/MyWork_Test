namespace WinFormsAppTest9_2.book
{
    partial class BookAddAndEidt
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
            button1 = new AntdUI.Button();
            label5 = new AntdUI.Label();
            test_input = new AntdUI.Input();
            label4 = new AntdUI.Label();
            authorName_input = new AntdUI.Input();
            label3 = new AntdUI.Label();
            bookName_input = new AntdUI.Input();
            label6 = new AntdUI.Label();
            price_inputNumber = new AntdUI.InputNumber();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(263, 12);
            label1.Name = "label1";
            label1.Size = new Size(251, 65);
            label1.TabIndex = 1;
            label1.Text = "";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(285, 393);
            button1.Name = "button1";
            button1.Size = new Size(212, 52);
            button1.TabIndex = 29;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Location = new Point(231, 212);
            label5.Name = "label5";
            label5.Size = new Size(106, 36);
            label5.TabIndex = 27;
            label5.Text = "价格：";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // test_input
            // 
            test_input.Location = new Point(355, 263);
            test_input.Multiline = true;
            test_input.Name = "test_input";
            test_input.PlaceholderColorExtend = "";
            test_input.PlaceholderText = "请输入图书名称";
            test_input.Size = new Size(212, 124);
            test_input.TabIndex = 28;
            // 
            // label4
            // 
            label4.Location = new Point(231, 272);
            label4.Name = "label4";
            label4.Size = new Size(106, 36);
            label4.TabIndex = 25;
            label4.Text = "标签：";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // authorName_input
            // 
            authorName_input.Location = new Point(355, 143);
            authorName_input.Name = "authorName_input";
            authorName_input.PlaceholderColorExtend = "";
            authorName_input.PlaceholderText = "请输入作者姓名";
            authorName_input.Size = new Size(212, 54);
            authorName_input.TabIndex = 24;
            // 
            // label3
            // 
            label3.Location = new Point(231, 152);
            label3.Name = "label3";
            label3.Size = new Size(106, 36);
            label3.TabIndex = 23;
            label3.Text = "作者：";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bookName_input
            // 
            bookName_input.Location = new Point(355, 83);
            bookName_input.Name = "bookName_input";
            bookName_input.PlaceholderColorExtend = "";
            bookName_input.PlaceholderText = "请输入图书名称";
            bookName_input.Size = new Size(212, 54);
            bookName_input.TabIndex = 22;
            // 
            // label6
            // 
            label6.Location = new Point(231, 92);
            label6.Name = "label6";
            label6.Size = new Size(106, 36);
            label6.TabIndex = 21;
            label6.Text = "图书名称：";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // price_inputNumber
            // 
            price_inputNumber.Location = new Point(355, 203);
            price_inputNumber.Name = "price_inputNumber";
            price_inputNumber.PlaceholderText = "请输入价格";
            price_inputNumber.Size = new Size(212, 54);
            price_inputNumber.TabIndex = 26;
            price_inputNumber.Text = "0";
            // 
            // BookAddAndEidt
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 463);
            Controls.Add(button1);
            Controls.Add(price_inputNumber);
            Controls.Add(label5);
            Controls.Add(test_input);
            Controls.Add(label4);
            Controls.Add(authorName_input);
            Controls.Add(label3);
            Controls.Add(bookName_input);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "BookAddAndEidt";
            Text = "BookAddAndEidt";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Button button1;
        private AntdUI.Label label5;
        private AntdUI.Input test_input;
        private AntdUI.Label label4;
        private AntdUI.Input authorName_input;
        private AntdUI.Label label3;
        private AntdUI.Input bookName_input;
        private AntdUI.Label label6;
        private AntdUI.InputNumber price_inputNumber;
    }
}