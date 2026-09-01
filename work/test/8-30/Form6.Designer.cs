namespace WinFormsAppTest8_25
{
    partial class Form6
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
            addBookBtn = new AntdUI.Button();
            editBookBtn = new AntdUI.Button();
            delBookBtn = new AntdUI.Button();
            seachBookBtn = new AntdUI.Button();
            backBtn = new AntdUI.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(255, 12);
            label1.Name = "label1";
            label1.Size = new Size(283, 75);
            label1.TabIndex = 0;
            label1.Text = "欢迎来到图书管理系统";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addBookBtn
            // 
            addBookBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            addBookBtn.Location = new Point(255, 147);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.Size = new Size(283, 62);
            addBookBtn.TabIndex = 1;
            addBookBtn.Text = "新增书籍";
            addBookBtn.Click += addBookBtn_Click;
            // 
            // editBookBtn
            // 
            editBookBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            editBookBtn.Location = new Point(255, 215);
            editBookBtn.Name = "editBookBtn";
            editBookBtn.Size = new Size(283, 62);
            editBookBtn.TabIndex = 2;
            editBookBtn.Text = "编辑书籍";
            editBookBtn.Click += editBookBtn_Click;
            // 
            // delBookBtn
            // 
            delBookBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            delBookBtn.Location = new Point(255, 283);
            delBookBtn.Name = "delBookBtn";
            delBookBtn.Size = new Size(283, 62);
            delBookBtn.TabIndex = 3;
            delBookBtn.Text = "删除书籍";
            delBookBtn.Click += delBookBtn_Click;
            // 
            // seachBookBtn
            // 
            seachBookBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            seachBookBtn.Location = new Point(255, 351);
            seachBookBtn.Name = "seachBookBtn";
            seachBookBtn.Size = new Size(283, 62);
            seachBookBtn.TabIndex = 4;
            seachBookBtn.Text = "查看书籍";
            seachBookBtn.Click += seachBookBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            backBtn.Location = new Point(693, 376);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(95, 62);
            backBtn.TabIndex = 5;
            backBtn.Text = "退出";
            backBtn.Click += backBtn_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backBtn);
            Controls.Add(seachBookBtn);
            Controls.Add(delBookBtn);
            Controls.Add(editBookBtn);
            Controls.Add(addBookBtn);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Button addBookBtn;
        private AntdUI.Button editBookBtn;
        private AntdUI.Button delBookBtn;
        private AntdUI.Button seachBookBtn;
        private AntdUI.Button backBtn;
    }
}