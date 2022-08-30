namespace Yemekhane_Sistemi
{
    partial class AdminPanel
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
            this.btn_check = new System.Windows.Forms.Button();
            this.datagrid_siparis = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.datagrid_orders = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_siparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(912, 56);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(143, 63);
            this.btn_check.TabIndex = 1;
            this.btn_check.Text = "Tamamla";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // datagrid_siparis
            // 
            this.datagrid_siparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_siparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_siparis.Location = new System.Drawing.Point(26, 56);
            this.datagrid_siparis.Name = "datagrid_siparis";
            this.datagrid_siparis.ReadOnly = true;
            this.datagrid_siparis.RowHeadersWidth = 51;
            this.datagrid_siparis.RowTemplate.Height = 29;
            this.datagrid_siparis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_siparis.Size = new System.Drawing.Size(496, 198);
            this.datagrid_siparis.TabIndex = 2;
            this.datagrid_siparis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_siparis_CellContentClick);
            this.datagrid_siparis.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_siparis_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(232, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kişi Tablosu";
            // 
            // datagrid_orders
            // 
            this.datagrid_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_orders.Location = new System.Drawing.Point(528, 56);
            this.datagrid_orders.Name = "datagrid_orders";
            this.datagrid_orders.ReadOnly = true;
            this.datagrid_orders.RowHeadersWidth = 51;
            this.datagrid_orders.RowTemplate.Height = 29;
            this.datagrid_orders.Size = new System.Drawing.Size(247, 200);
            this.datagrid_orders.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(570, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sipariş Listesi";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datagrid_orders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagrid_siparis);
            this.Controls.Add(this.btn_check);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_siparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.DataGridView datagrid_siparis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagrid_orders;
        private System.Windows.Forms.Label label2;
    }
}