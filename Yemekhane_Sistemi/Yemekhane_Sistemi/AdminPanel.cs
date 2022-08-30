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
    public partial class AdminPanel : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        public AdminPanel()
        {
            InitializeComponent();
        }

        void getMeals()
        {
            try
            {
                conn = new SqlConnection("Data Source=HUMA-V4;Initial Catalog=Sevilay;Integrated Security=True");
                conn.Open();
                adapter = new SqlDataAdapter("select stdno as OgrenciNumara, namesurname as İsim,roomNo as [Oda Numarası], _time as tarih from Orders", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                datagrid_siparis.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.Close();
            }


        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            getMeals();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_orderGet_Click(object sender, EventArgs e)
        {
            
        }
        string stdno;
        private void datagrid_siparis_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            stdno = datagrid_siparis.CurrentRow.Cells[0].Value.ToString();
            try
            {
                conn = new SqlConnection("Data Source=**;Initial Catalog=**;Integrated Security=**");
                conn.Open();
                adapter = new SqlDataAdapter("select orderName as Siparis from Meals where stdno = '"+stdno+"'", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                datagrid_orders.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void datagrid_siparis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=**;Initial Catalog=**;Integrated Security=**");
            conn.Open();
            adapter = new SqlDataAdapter("delete from Orders where stdno = '"+stdno+"'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter = new SqlDataAdapter("delete from Meals where stdno = '" + stdno + "'", conn);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            
            getMeals();
        }
    }
}
