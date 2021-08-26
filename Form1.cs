using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaccineRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Idtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdLabel_Click(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            String str = "Data Source=LAPTOP-1FNK8D3C;Initial Catalog=VaccineReg;Integrated Security=True";
            String queryTwo = "insert into  Vaccinations(Id, Surname, FirstName, Gender, Province)" +
                    "Values('" + Int64.Parse(Idtxt.Text) + "','" + SurnameTxt.Text + "','" + FirstNameTxt.Text + "','" + GenderTxt.Text + "','" + ProvinceCB.Text + "')";

            

            SqlConnection con = new SqlConnection(str);

            SqlCommand cmd = new SqlCommand(queryTwo, con);

            con.Open();
            cmd.ExecuteNonQuery();
            



            MessageBox.Show("It has been added to your database :)");

            con.Close();
        }
    }
}
