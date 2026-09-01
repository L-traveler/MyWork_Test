namespace WinFormsAppTest8_25.book
{
    partial class DelBookForm
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
            panel1 = new AntdUI.Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(62, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 280);
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            // 
            // DelBookForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 448);
            Controls.Add(panel1);
            Name = "DelBookForm";
            Text = "DelBookForm";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel panel1;
    }
}