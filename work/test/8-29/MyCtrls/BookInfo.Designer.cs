namespace WinFormsAppTest8_25.MyCtrls
{
    partial class BookInfo
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
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            button1 = new AntdUI.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(93, 54);
            label1.TabIndex = 0;
            label1.Text = "";
            // 
            // label2
            // 
            label2.Location = new Point(102, 3);
            label2.Name = "label2";
            label2.Size = new Size(93, 54);
            label2.TabIndex = 1;
            label2.Text = "";
            // 
            // label3
            // 
            label3.Location = new Point(187, 3);
            label3.Name = "label3";
            label3.Size = new Size(93, 54);
            label3.TabIndex = 2;
            label3.Text = "";
            // 
            // label4
            // 
            label4.Location = new Point(256, 3);
            label4.Name = "label4";
            label4.Size = new Size(93, 54);
            label4.TabIndex = 3;
            label4.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(355, 3);
            button1.Name = "button1";
            button1.Size = new Size(105, 54);
            button1.TabIndex = 4;
            button1.Text = "删除";
            button1.Click += button1_Click;
            // 
            // BookInfo
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BookInfo";
            Size = new Size(463, 60);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Button button1;
    }
}
