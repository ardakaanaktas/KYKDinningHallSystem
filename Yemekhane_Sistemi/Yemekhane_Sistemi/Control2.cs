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
    public partial class Control2 : UserControl
    {
        
        
        public Control2()
        {
            InitializeComponent();
        }
        List<Meal> meals = new List<Meal>();
        class Meal
        {
            string name;
            decimal amount;

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public decimal Amount
            {
                get
                {
                    return amount;
                }

                set
                {
                    amount = value;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.Open();
            }
            catch (Exception)
            {

                
            }
            finally
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Meal meal = new Meal();
            meal.Name = "Sandal";
            meal.Amount =nud_sandal.Value;
            meals.Add(meal);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Control2_Load(object sender, EventArgs e)
        {

        }
    }
}
