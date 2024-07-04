using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonuYönetimSistemi
{
    public partial class YeniEğitmen : Form
    {
        public YeniEğitmen()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String firstName = txtFname.Text;
            String lastName = txtLname.Text;
            String gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            DateTime dob = dateTimePickerDOB.Value;
            Int64 phone = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            DateTime joinDate = dateTimePickerJOINDate.Value;
            String city = txtCity.Text;

            string connString = "Host=localhost;Username=postgres;Password=abc123;Database=gym";

            using (NpgsqlConnection con = new NpgsqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO new_trainer(first_name, last_name, gender, dob, phone, email, join_date, city) " +
                                   "VALUES (@firstName, @lastName, @gender, @dob, @phone, @mail, @joinDate, @city)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("firstName", firstName);
                        cmd.Parameters.AddWithValue("lastName", lastName);
                        cmd.Parameters.AddWithValue("gender", gender);
                        cmd.Parameters.AddWithValue("dob", dob);
                        cmd.Parameters.AddWithValue("phone", phone);
                        cmd.Parameters.AddWithValue("mail", email);
                        cmd.Parameters.AddWithValue("joinDate", joinDate);
                        cmd.Parameters.AddWithValue("city", city);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Eğitmen kaydedildi.");
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
            txtEmail.Clear();
            txtCity.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJOINDate.Value = DateTime.Now;
        }
    }
}
