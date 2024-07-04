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
    public partial class Ekipmanlar : Form
    {
        public Ekipmanlar()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String EquipName = txtEquipName.Text;
            String Description = txtDescription.Text;
            String MUsed = txtMusclesUsed.Text;
            String DDate = dateTimePickerDeliveryDate.Text;
            Int64 cost = Int64.Parse(txtCost.Text);

            // PostgreSQL bağlantı dizesi
            string connString = "Host=localhost;Username=postgres;Password=abc123;Database=gym";

            using (NpgsqlConnection con = new NpgsqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Equipment(EquipName, EDescription, MUsed, DDate, Cost) " +
                                   "VALUES (@EquipName, @Description, @MUsed, @DDate, @Cost)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                    {
                        // Parametreleri ekle
                        cmd.Parameters.AddWithValue("EquipName", EquipName);
                        cmd.Parameters.AddWithValue("Description", Description);
                        cmd.Parameters.AddWithValue("MUsed", MUsed);
                        cmd.Parameters.AddWithValue("DDate", DDate);
                        cmd.Parameters.AddWithValue("Cost", cost);

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
            txtEquipName.Clear();
            txtDescription.Clear();
            txtMusclesUsed.Clear();
            txtCost.Clear();
            dateTimePickerDeliveryDate.Value = DateTime.Now;
        }

        private void btnViewEq_Click(object sender, EventArgs e)
        {
            EkipmanlarıGöster ve = new EkipmanlarıGöster();
            ve.Show();
        }
    }
}
