using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuYönetimSistemi
{
    public partial class yeniPersonel : Form
    {
        public yeniPersonel()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String fname = txtFname.Text;
            String lname = txtLname.Text;

            String gender = "";
            bool isChecked = radioButton1.Checked;

            if (isChecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String joindate = dateTimePickerJOINDate.Text;
            String state = txtState.Text;
            String city = txtCity.Text;

            // PostgreSQL bağlantı dizesi
            string connString = "Host=localhost;Username=postgres;Password=abc123;Database=gym";

            using (NpgsqlConnection con = new NpgsqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO NewStaff(Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, Statee, City) " +
                                   "VALUES (@fname, @lname, @gender, @dob, @mobile, @mail, @joindate, @statee, @city)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                    {
                        // Parametreleri ekle
                        cmd.Parameters.AddWithValue("fname", fname);
                        cmd.Parameters.AddWithValue("lname", lname);
                        cmd.Parameters.AddWithValue("gender", gender);
                        cmd.Parameters.AddWithValue("dob", DateTime.Parse(dob));
                        cmd.Parameters.AddWithValue("mobile", mobile);
                        cmd.Parameters.AddWithValue("mail", email);
                        cmd.Parameters.AddWithValue("joindate", DateTime.Parse(joindate));
                        cmd.Parameters.AddWithValue("statee", state);
                        cmd.Parameters.AddWithValue("city", city);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Veri kaydedildi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtMobile.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtEmail.Clear();

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJOINDate.Value = DateTime.Now;

        }
    }
}
