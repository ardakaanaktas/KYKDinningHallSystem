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
    public partial class Control4 : UserControl
    {
        public Control4()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=**;Initial Catalog=**;Integrated Security=**");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Control4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, password;

            username = txt_username.Text;
            password = txt_password.Text;

            try
            {
                String querry = "SELECT * FROM AdminLogin WHERE username = '" + username + "' AND password = '" + password + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querry, conn);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    password = txt_password.Text;


                    AdminPanel panel = new AdminPanel();
                    panel.Show();
                    


                }
            }
            catch
            {
                MessageBox.Show("Geçersiz Şifre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
