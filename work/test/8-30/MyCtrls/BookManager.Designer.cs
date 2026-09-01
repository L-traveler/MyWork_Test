namespace WinFormsAppTest8_25.MyCtrls
{
    partial class BookManager
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new AntdUI.Button();
            price_inputNumber = new AntdUI.InputNumber();
            label5 = new AntdUI.Label();
            test_input = new AntdUI.Input();
            label4 = new AntdUI.Label();
            authorName_input = new AntdUI.Input();
            label3 = new AntdUI.Label();
            bookName_input = new AntdUI.Input();
            label2 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(132, 390);
            button1.Name = "button1";
            button1.Size = new Size(212, 52);
            button1.TabIndex = 19;
            button1.Click += button1_Click;
            // 
            // price_inputNumber
            // 
            price_inputNumber.Location = new Point(132, 175);
            price_inputNumber.Name = "price_inputNumber";
            price_inputNumber.PlaceholderText = "请输入价格";
            price_inputNumber.Size = new Size(212, 54);
            price_inputNumber.TabIndex = 16;
            // 
            // label5
            // 
            label5.Location = new Point(8, 184);
            label5.Name = "label5";
            label5.Size = new Size(106, 36);
            label5.TabIndex = 17;
            label5.Text = "价格：";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // test_input
            // 
            test_input.Location = new Point(132, 235);
            test_input.Multiline = true;
            test_input.Name = "test_input";
            test_input.PlaceholderColorExtend = "";
            test_input.PlaceholderText = "请输入图书名称";
            test_input.Size = new Size(212, 149);
            test_input.TabIndex = 18;
            // 
            // label4
            // 
            label4.Location = new Point(8, 244);
            label4.Name = "label4";
            label4.Size = new Size(106, 36);
            label4.TabIndex = 15;
            label4.Text = "标签：";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // authorName_input
            // 
            authorName_input.Location = new Point(132, 115);
            authorName_input.Name = "authorName_input";
            authorName_input.PlaceholderColorExtend = "";
            authorName_input.PlaceholderText = "请输入作者姓名";
            authorName_input.Size = new Size(212, 54);
            authorName_input.TabIndex = 14;
            // 
            // label3
            // 
            label3.Location = new Point(8, 124);
            label3.Name = "label3";
            label3.Size = new Size(106, 36);
            label3.TabIndex = 13;
            label3.Text = "作者：";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bookName_input
            // 
            bookName_input.Location = new Point(132, 55);
            bookName_input.Name = "bookName_input";
            bookName_input.PlaceholderColorExtend = "";
            bookName_input.PlaceholderText = "请输入图书名称";
            bookName_input.Size = new Size(212, 54);
            bookName_input.TabIndex = 12;
            // 
            // label2
            // 
            label2.Location = new Point(8, 64);
            label2.Name = "label2";
            label2.Size = new Size(106, 36);
            label2.TabIndex = 11;
            label2.Text = "图书名称：";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(118, 3);
            label1.Name = "label1";
            label1.Size = new Size(143, 35);
            label1.TabIndex = 10;
            label1.Text = "图书";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BookManager
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "BookManager";
            Size = new Size(846, 600);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button button1;
        private AntdUI.InputNumber price_inputNumber;
        private AntdUI.Label label5;
        private AntdUI.Input test_input;
        private AntdUI.Label label4;
        private AntdUI.Input authorName_input;
        private AntdUI.Label label3;
        private AntdUI.Input bookName_input;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
    }
}
