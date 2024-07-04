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
    public partial class AntrenörAra : Form
    {
        public AntrenörAra()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtSearch.Text != "")
            {
                // PostgreSQL bağlantı dizesi
                string connString = "Host=localhost;Username=postgres;Password=abc123;Database=gym";

                using (NpgsqlConnection con = new NpgsqlConnection(connString))
                {
                    try
                    {
                        con.Open();
                        string query = "SELECT * FROM new_coach WHERE coach_id = @coach_id";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("coach_id", int.Parse(txtSearch.Text));

                            NpgsqlDataAdapter DA = new NpgsqlDataAdapter(cmd);
                            DataSet DS = new DataSet();
                            DA.Fill(DS);

                            dataGridView1.DataSource = DS.Tables[0];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ID giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
 }

