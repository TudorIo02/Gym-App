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


namespace SalaFitness
{
    public partial class BazaDeDate_Echipamente : Form
    {
        private string connectionString = "data source=(localdb)\\MSSQLLocalDB;database=Echipamente;integrated security=True";
        private string selectCommandText = "SELECT * FROM dbo.[Table]";
        public BazaDeDate_Echipamente()
        {
            InitializeComponent();
        }

        private void BazaDeDate_Echipamente_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(selectCommandText, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Echipamente");
                    dataGridView1.DataSource = ds.Tables["Echipamente"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Echipamente i = null;
            EchipamenteSala form = new EchipamenteSala(i);
            form.EchipamentAdaugat += (s, ev) => RefreshData();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIdInchiriere = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                var confirmResult = MessageBox.Show("Sigur doresti sa stergi aceasta inregistrare?", "Confirmare Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("DELETE FROM dbo.[Table] WHERE Id = @Id", con);
                            cmd.Parameters.AddWithValue("@Id", selectedIdInchiriere);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Inregistrarea a fost stearsa cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RefreshData();
                            }
                            else
                            {
                                MessageBox.Show("Nu s-a gasit nicio inregistrare cu id specificat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"A aparut o eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Te rog sa selectezi un rand pentru a sterge.", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idAparat = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string nume = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string grupa_muschi = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                DateTime data_livrare = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value);
                double pret = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value);
                Echipamente i = new Echipamente
                {
                    IdAparat = idAparat,
                    Nume = nume,
                    Grupa_muschi = grupa_muschi,
                    Data_livrare = data_livrare,
                    Pret = pret
                };

                EchipamenteSala form = new EchipamenteSala(i);
                form.EchipamentAdaugat += (s, ev) => RefreshData();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshData();
                }
            }
            else
            {
                MessageBox.Show("Te rog să selectezi un rând pentru a modifica.", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void resetareIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DBCC CHECKIDENT ('dbo.[Table]', RESEED, 100);", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Identitatea a fost resetata.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A aparut o eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
    }
}

