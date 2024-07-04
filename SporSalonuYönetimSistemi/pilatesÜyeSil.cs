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
    public partial class pilatesÜyeSil : Form
    {
        public pilatesÜyeSil()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // PostgreSQL bağlantı dizesi
            string connString = "Host=localhost;Username=postgres;Password=abc123;Database=gym";

            if (MessageBox.Show("Bu verileriniz silinecektir. Kabul ediyor musunuz?", "Veriyi Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (NpgsqlConnection con = new NpgsqlConnection(connString))
                {
                    try
                    {
                        con.Open();
                        string deleteQuery = "DELETE FROM newPilatesMember WHERE ID = @id";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(deleteQuery, con))
                        {
                            cmd.Parameters.AddWithValue("id", int.Parse(textBox1.Text));
                            cmd.ExecuteNonQuery();
                        }

                        // Silme işleminden sonra verileri yeniden yüklemek için.
                        LoadData(con);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                this.Activate();
                using (NpgsqlConnection con = new NpgsqlConnection(connString))
                {
                    try
                    {
                        con.Open();
                        // Verileri yeniden yükle
                        LoadData(con);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }

        private void ÜyeSilme_Load(object sender, EventArgs e)
        {
            string connString = "Host=localhost;Username=postgres;Password=abc123;Database=gym";

            using (NpgsqlConnection con = new NpgsqlConnection(connString))
            {
                try
                {
                    con.Open();
                    LoadData(con);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void LoadData(NpgsqlConnection con)
        {
            string selectQuery = "SELECT * FROM newPilatesMember";
            using (NpgsqlCommand cmd = new NpgsqlCommand(selectQuery, con))
            {
                NpgsqlDataAdapter DA = new NpgsqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }
    }
}
