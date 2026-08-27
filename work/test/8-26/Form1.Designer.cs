namespace WinFormsAppTest8_25
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            EagleBtn = new Button();
            BridBtn = new Button();
            CatBtn = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox3 = new PictureBox();
            tabPage2 = new TabPage();
            pictureBox4 = new PictureBox();
            tabPage3 = new TabPage();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // Btn1
            // 
            Btn1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            Btn1.Location = new Point(12, 293);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(218, 60);
            Btn1.TabIndex = 0;
            Btn1.Text = "打开";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Btn1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 275);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(252, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(323, 209);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(EagleBtn);
            panel1.Controls.Add(BridBtn);
            panel1.Controls.Add(CatBtn);
            panel1.Location = new Point(252, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 61);
            panel1.TabIndex = 3;
            // 
            // EagleBtn
            // 
            EagleBtn.BackColor = Color.DarkGray;
            EagleBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            EagleBtn.Location = new Point(242, 3);
            EagleBtn.Name = "EagleBtn";
            EagleBtn.Size = new Size(78, 55);
            EagleBtn.TabIndex = 2;
            EagleBtn.Text = "老鹰";
            EagleBtn.UseVisualStyleBackColor = false;
            EagleBtn.Click += EagleBtn_Click;
            // 
            // BridBtn
            // 
            BridBtn.BackColor = Color.DarkGray;
            BridBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            BridBtn.Location = new Point(122, 3);
            BridBtn.Name = "BridBtn";
            BridBtn.Size = new Size(78, 55);
            BridBtn.TabIndex = 1;
            BridBtn.Text = "小鸟";
            BridBtn.UseVisualStyleBackColor = false;
            BridBtn.Click += BridBtn_Click;
            // 
            // CatBtn
            // 
            CatBtn.BackColor = Color.DarkGray;
            CatBtn.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            CatBtn.Location = new Point(0, 3);
            CatBtn.Name = "CatBtn";
            CatBtn.Size = new Size(78, 55);
            CatBtn.TabIndex = 0;
            CatBtn.Text = "小猫";
            CatBtn.UseVisualStyleBackColor = false;
            CatBtn.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(252, 302);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(405, 207);
            tabControl1.TabIndex = 4;
            tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(397, 174);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "小猫";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(6, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(385, 161);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(397, 174);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "小鸟";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(9, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(381, 155);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(pictureBox5);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(397, 174);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "老鹰";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(9, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(382, 161);
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 510);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Btn1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button CatBtn;
        private Button EagleBtn;
        private Button BridBtn;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
