namespace WinFormsAppTest9_12_02.JieMian
{
    partial class UserList
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
            label1 = new Label();
            table1 = new AntdUI.Table();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(327, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 37);
            label1.TabIndex = 9;
            label1.Text = "客户列表";
            // 
            // table1
            // 
            table1.Gap = 12;
            table1.Location = new Point(12, 63);
            table1.Name = "table1";
            table1.Size = new Size(776, 375);
            table1.TabIndex = 10;
            table1.Text = "table1";
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(table1);
            Controls.Add(label1);
            Name = "UserList";
            Text = "UserList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private AntdUI.Table table1;
    }
}