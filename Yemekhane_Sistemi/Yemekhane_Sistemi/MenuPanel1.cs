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
    public partial class MenuPanel1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter;

        string name, surname, roomNo;
        int stdno;
        public MenuPanel1(string Name, string Surname, string RoomNo,int stdNo)
        {
            name = Name;
            surname = Surname;
            roomNo = RoomNo;
            stdno = stdNo;
            InitializeComponent();
        }

        private void btn_soslutavuk_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_soslutavuk.Text);
        }

        private void btn_sandal_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_sandal.Text);
        }

        private void btn_mercimekcorba_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_mercimekcorba.Text);
        }

        private void btn_misircorba_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_misircorba.Text);
        }

        private void btn_ezogelincorba_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_ezogelincorba.Text);
        }

        private void btn_kuru_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_kuru.Text);
        }

        private void btn_ispanak_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_ispanak.Text);
        }

        private void btn_yaylacorba_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_yaylacorba.Text);
        }

        private void btn_bulgur_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_bulgur.Text);
        }

        private void btn_soda_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_soda.Text);
        }

        private void btn_makarna_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_makarna.Text);
        }

        private void btn_yesilsalata_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_yesilsalata.Text);
        }

        private void btn_cigkofte_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_cigkofte.Text);
        }

        private void btn_pirinc_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_pirinc.Text);
        }

        private void btn_ayran_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_ayran.Text);
        }

        private void btn_ciger_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_ciger.Text);
        }

        private void btn_tazefasulye_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_tazefasulye.Text);
        }

        private void btn_firintavuk_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_firintavuk.Text);
        }

        private void btn_guvec_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_guvec.Text);
        }

        private void btn_su_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_su.Text);
        }

        private void btn_cileksoda_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_cileksoda.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list_meal.Items.Remove(list_meal.SelectedItem);
        }
        private void btn_havuctarator_Click(object sender, EventArgs e)
        {
            list_meal.Items.Add(btn_havuctarator.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source=**;Initial Catalog=**;Integrated Security=**");
                conn.Open();
                foreach (var item in list_meal.Items)
                {
                    String querry = "insert into Meals (stdno,orderName) values ('"+stdno+"','" +item.ToString()+ "')";
                    adapter = new SqlDataAdapter(querry, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                }
                MessageBox.Show("İşlem Başarılı");
                this.Close();
                string namesurname = name + surname;
                adapter = new SqlDataAdapter("insert into Orders(namesurname,roomNo,_time,stdno) values ('"+namesurname+"',"+roomNo+",GETDATE(),'"+stdno+"')",conn);
                DataTable dataTable1 = new DataTable();
                adapter.Fill(dataTable1);

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

        

       

        private void MenuPanel1_Load(object sender, EventArgs e)
        {
            lbl_name.Text = name;
            lbl_roomNo.Text = roomNo;
            lbl_surname.Text = surname;
        }
    }
}
