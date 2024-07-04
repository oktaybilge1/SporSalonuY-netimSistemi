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
    public partial class EkipmanlarıGöster : Form
    {
        public EkipmanlarıGöster()
        {
            InitializeComponent();
        }

        private void EkipmanlarıGöster_Load(object sender, EventArgs e)
        {
            // PostgreSQL bağlantı dizesi
            string connString = "Host=localhost;Username=postgres;Password=abc123;Database=gym";

            using (NpgsqlConnection con = new NpgsqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Equipment";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                    {
                        NpgsqlDataAdapter DA = new NpgsqlDataAdapter(cmd);
                        DataSet DS = new DataSet();
                        DA.Fill(DS);

                        // Verileri DataGridView kontrolüne atama
                        dataGridView1.DataSource = DS.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
