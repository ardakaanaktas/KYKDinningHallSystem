namespace Yemekhane_Sistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_adminLogin = new System.Windows.Forms.Button();
            this.btn_studentLogin = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_infoi = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_adminLogin);
            this.panel1.Controls.Add(this.btn_studentLogin);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Location = new System.Drawing.Point(12, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 585);
            this.panel1.TabIndex = 0;
            // 
            // btn_adminLogin
            // 
            this.btn_adminLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_adminLogin.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_adminLogin.Location = new System.Drawing.Point(-3, 298);
            this.btn_adminLogin.Name = "btn_adminLogin";
            this.btn_adminLogin.Size = new System.Drawing.Size(140, 84);
            this.btn_adminLogin.TabIndex = 3;
            this.btn_adminLogin.Text = "YÖNETİCİ GİRİŞİ";
            this.btn_adminLogin.UseVisualStyleBackColor = false;
            this.btn_adminLogin.Click += new System.EventHandler(this.btn_adminLogin_Click);
            // 
            // btn_studentLogin
            // 
            this.btn_studentLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_studentLogin.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_studentLogin.Location = new System.Drawing.Point(0, 197);
            this.btn_studentLogin.Name = "btn_studentLogin";
            this.btn_studentLogin.Size = new System.Drawing.Size(140, 84);
            this.btn_studentLogin.TabIndex = 3;
            this.btn_studentLogin.Text = "ÖĞRENCİ GİRİŞİ";
            this.btn_studentLogin.UseVisualStyleBackColor = false;
            this.btn_studentLogin.Click += new System.EventHandler(this.btn_studentLogin_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_home.Location = new System.Drawing.Point(0, 98);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(140, 84);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "ANA SAYFA";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1344, 108);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(417, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kredi Yurtlar Kurumu Yemek Yardım";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_info.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_info.Location = new System.Drawing.Point(1005, 680);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 22);
            this.lbl_info.TabIndex = 2;
            this.lbl_info.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_infoi
            // 
            this.lbl_infoi.AutoSize = true;
            this.lbl_infoi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_infoi.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_infoi.Location = new System.Drawing.Point(1005, 653);
            this.lbl_infoi.Name = "lbl_infoi";
            this.lbl_infoi.Size = new System.Drawing.Size(172, 22);
            this.lbl_infoi.TabIndex = 3;
            this.lbl_infoi.Text = "Connection State:";
            this.lbl_infoi.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // pnl_main
            // 
            this.pnl_main.Location = new System.Drawing.Point(158, 126);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1198, 501);
            this.pnl_main.TabIndex = 4;
            this.pnl_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 733);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.lbl_infoi);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_adminLogin;
        private System.Windows.Forms.Button btn_studentLogin;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label lbl_infoi;
        private System.Windows.Forms.Panel pnl_main;
    }
}
