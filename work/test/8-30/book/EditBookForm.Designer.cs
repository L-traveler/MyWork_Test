namespace WinFormsAppTest8_25.book
{
    partial class EditBookForm
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
            bookManager1 = new WinFormsAppTest8_25.MyCtrls.BookManager("编辑");
            SuspendLayout();
            // 
            // bookManager1
            // 
            bookManager1.Location = new Point(98, 15);
            bookManager1.Name = "bookManager1";
            bookManager1.Size = new Size(517, 432);
            bookManager1.TabIndex = 0;
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 482);
            Controls.Add(bookManager1);
            Name = "EditBookForm";
            Text = "EditBookForm";
            ResumeLayout(false);
        }

        #endregion

        private MyCtrls.BookManager bookManager1;
    }
}