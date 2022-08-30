namespace Yemekhane_Sistemi
{
    partial class Control3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_StudentNo = new System.Windows.Forms.Label();
            this.txt_studentNo = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_roomNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Green;
            this.btn_login.Location = new System.Drawing.Point(755, 175);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(136, 65);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "GİRİŞ";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // lb_StudentNo
            // 
            this.lb_StudentNo.AutoSize = true;
            this.lb_StudentNo.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_StudentNo.Location = new System.Drawing.Point(163, 190);
            this.lb_StudentNo.Name = "lb_StudentNo";
            this.lb_StudentNo.Size = new System.Drawing.Size(146, 28);
            this.lb_StudentNo.TabIndex = 0;
            this.lb_StudentNo.Text = "ÖĞRENCİ NO:";
            this.lb_StudentNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_studentNo
            // 
            this.txt_studentNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_studentNo.Location = new System.Drawing.Point(333, 197);
            this.txt_studentNo.Name = "txt_studentNo";
            this.txt_studentNo.Size = new System.Drawing.Size(363, 20);
            this.txt_studentNo.TabIndex = 1;
            this.txt_studentNo.TextChanged += new System.EventHandler(this.Student_No_TextChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(336, 278);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(28, 22);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "--";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_surname.Location = new System.Drawing.Point(336, 319);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(28, 22);
            this.lbl_surname.TabIndex = 3;
            this.lbl_surname.Text = "--";
            this.lbl_surname.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // lbl_roomNo
            // 
            this.lbl_roomNo.AutoSize = true;
            this.lbl_roomNo.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_roomNo.Location = new System.Drawing.Point(336, 356);
            this.lbl_roomNo.Name = "lbl_roomNo";
            this.lbl_roomNo.Size = new System.Drawing.Size(28, 22);
            this.lbl_roomNo.TabIndex = 3;
            this.lbl_roomNo.Text = "--";
            this.lbl_roomNo.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // Control3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_roomNo);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_studentNo);
            this.Controls.Add(this.lb_StudentNo);
            this.Name = "Control3";
            this.Size = new System.Drawing.Size(1198, 501);
            this.Load += new System.EventHandler(this.Control3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lb_StudentNo;
        private System.Windows.Forms.TextBox txt_studentNo;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_roomNo;
    }
}
