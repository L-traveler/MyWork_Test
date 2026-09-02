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
            flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(45, 28);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(507, 274);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Text = "flowLayoutPanel1";
            flowLayoutPanel1.WrapContents = false;
            // 
            // DelBookForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 448);
            Controls.Add(flowLayoutPanel1);
            Name = "DelBookForm";
            Text = "DelBookForm";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
    }
}