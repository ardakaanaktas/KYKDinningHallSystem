using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yemekhane_Sistemi
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new Form1();
                return _obj;
            }
        }
        public Panel PnlConteiner
        {
            get { return pnl_main; }
            set { pnl_main = value; }
        }
        
        public string conStr = "Data Source=**;Initial Catalog=**;Integrated Security=**";

        
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
            

            try
            {
                SqlConnection conn = new SqlConnection(conStr);
                conn.Open();
                lbl_info.BackColor = Color.Green;
                lbl_info.Text = "Database Connection Succeeded";
            }
            catch (Exception err)
            {
                lbl_info.BackColor = Color.Red;
                lbl_info.Text = err.Message;
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            Control1 control1 = new Control1();
            control1.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(control1);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btn_studentLogin_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            Control3 control3 = new Control3();
            control3.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(control3);
            
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            Control2 control2 = new Control2();
            control2.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(control2);
            
        }

        private void btn_adminLogin_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            Control4 control4 = new Control4();
            control4.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(control4);
        }
    }
}
