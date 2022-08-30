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
    public partial class Control3 : UserControl
    {
        public string conStr = "Data Source=HUMA-V4;Initial Catalog=Sevilay;Integrated Security=True";

        public Control3()
        {
            InitializeComponent();
        }

        private void Control3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Student_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conStr);
                conn.Open();
                string rec = "SELECT * FROM STUDENTS WHERE Student_No=@StudentNo";
                SqlCommand cmd = new SqlCommand(rec, conn);
                cmd.Parameters.AddWithValue("@StudentNo", txt_studentNo.Text);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lbl_name.Text = dr.GetValue(1).ToString();
                    lbl_surname.Text = dr.GetValue(2).ToString();
                    lbl_roomNo.Text = dr.GetValue(3).ToString();
                    MenuPanel1 panel = new MenuPanel1(lbl_name.Text, lbl_surname.Text, lbl_roomNo.Text,(int)dr.GetValue(0));

                    panel.Show();
                }
               

                conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }
    }
}
