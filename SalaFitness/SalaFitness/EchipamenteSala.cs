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
    public partial class EchipamenteSala : Form
    {
        public Echipamente eEchipamenteSala;
        public event EventHandler EchipamentAdaugat;
        public EchipamenteSala(Echipamente i)
        {
            InitializeComponent();
            if (i == null)
            {
                i = new Echipamente();
                i.IdAparat = 0;
                button1.Text = "Adauga";
            }
            else
            {
                button1.Text = "Editeaza";
               // tbId.Text = i.IdAparat.ToString();
                tbNume.Text = i.Nume;
                tbGrupa.Text = i.Grupa_muschi;
                dtpData.Value = i.Data_livrare;
                tbPret.Text = i.Pret.ToString();
            }
            eEchipamenteSala = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  eEchipamenteSala.IdAparat = string.IsNullOrEmpty(tbId.Text) ? 0 : Int32.Parse(tbId.Text);
            eEchipamenteSala.Nume = tbNume.Text;
            eEchipamenteSala.Grupa_muschi = tbGrupa.Text;
            eEchipamenteSala.Data_livrare = dtpData.Value;
            eEchipamenteSala.Pret = double.Parse(tbPret.Text);

            if (eEchipamenteSala.isValid)
            {
                using (SqlConnection con = new SqlConnection("data source = (localdb)\\MSSQLLocalDB; database = Echipamente; integrated security = True"))
                {
                    SqlCommand cmd;
                    con.Open();
                    if (eEchipamenteSala.IdAparat == 0)
                    {
                        cmd = new SqlCommand("INSERT INTO dbo.[Table] (Nume, Grupa_muschi, Data_livrare, Pret) VALUES (@Nume, @Grupa_muschi, @Data_livrare, @Pret)", con);
                    }
                    else
                    {
                        cmd = new SqlCommand("UPDATE dbo.[Table] SET Nume=@Nume, Grupa_muschi=@Grupa_muschi, Data_livrare=@Data_livrare, Pret=@Pret WHERE Id=@Id", con);
                        cmd.Parameters.AddWithValue("@Id", eEchipamenteSala.IdAparat);
                    }

                    cmd.Parameters.AddWithValue("@Nume", eEchipamenteSala.Nume);
                    cmd.Parameters.AddWithValue("@Grupa_muschi", eEchipamenteSala.Grupa_muschi);
                    cmd.Parameters.AddWithValue("@Data_livrare", eEchipamenteSala.Data_livrare);
                    cmd.Parameters.AddWithValue("@Pret", eEchipamenteSala.Pret);

                    cmd.ExecuteNonQuery();
                }

                this.DialogResult = DialogResult.OK;
                EchipamentAdaugat?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            else
            {
                var mesaj = string.Join("\n", eEchipamenteSala.ValidationErrors);
                MessageBox.Show(mesaj, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

