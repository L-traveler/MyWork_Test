namespace WinFormsAppTest9_2.book
{
    partial class BookShow
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
            table1 = new AntdUI.Table();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(278, 12);
            label1.Name = "label1";
            label1.Size = new Size(251, 65);
            label1.TabIndex = 0;
            label1.Text = "图书管理";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(68, 75);
            button1.Name = "button1";
            button1.Size = new Size(116, 51);
            button1.TabIndex = 1;
            button1.Text = "图书新增";
            button1.Click += button1_Click;
            // 
            // table1
            // 
            table1.Gap = 12;
            table1.Location = new Point(68, 142);
            table1.Name = "table1";
            table1.Size = new Size(682, 258);
            table1.TabIndex = 2;
            table1.Text = "table1";
            // 
            // BookShow
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(table1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "BookShow";
            Text = "BookShow";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Button button1;
        private AntdUI.Table table1;
    }
}