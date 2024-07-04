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
    public partial class pilatesYeniÜye : Form
    {
        public pilatesYeniÜye()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String fname = txtFirstName.Text;
            String lname = txtLastName.Text;

            String gender = "";

            bool isChacked = radioButton1.Checked;

            if (isChacked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            DateTime dob = dateTimePickerDOB.Value;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            DateTime joindate = dateTimePickerJoinDate.Value;
            String gymTime = comboBoxGymTime.Text;
            String address = txtAddress.Text;
            String membership = comboBoxMembership.Text;

            // PostgreSQL bağlantı dizesi
            string connString = "Host=localhost;Username=postgres;Password=abc123;Database=gym";

            using (NpgsqlConnection con = new NpgsqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO newPilatesMember(Fname, Lname, Gender, Dob, Mobile, Email, JoinDate, GymTime, Maddress, MembershipTime) " +
                                   "VALUES (@fname, @lname, @gender, @dob, @mobile, @mail, @joindate, @gymtime, @address, @membership)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                    {
                        // Parametreleri ekle
                        cmd.Parameters.AddWithValue("fname", fname);
                        cmd.Parameters.AddWithValue("lname", lname);
                        cmd.Parameters.AddWithValue("gender", gender);
                        cmd.Parameters.AddWithValue("dob", dob);
                        cmd.Parameters.AddWithValue("mobile", mobile);
                        cmd.Parameters.AddWithValue("mail", email);
                        cmd.Parameters.AddWithValue("joindate", joindate);
                        cmd.Parameters.AddWithValue("gymtime", gymTime);
                        cmd.Parameters.AddWithValue("address", address);
                        cmd.Parameters.AddWithValue("membership", membership);

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
            txtFirstName.Clear();
            txtLastName.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtMobile.Clear();
            txtEmail.Clear();

            comboBoxGymTime.ResetText();
            comboBoxMembership.ResetText();
            txtAddress.Clear();

            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;
        }
    }
}
