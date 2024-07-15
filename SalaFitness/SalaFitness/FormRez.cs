using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaFitness
{
    public partial class FormRez : Form
    {
        public Rezervari rFormRez;
        public FormRez(Rezervari r)
        {
            InitializeComponent();
            if (r == null )
            {
                r = new Rezervari();
                r.IdRezervare = 0;
                button1.Text = "Adauga";
            }
            else
            {
                button1.Text = "Editeaza";
                tbNume.Text = r.NumeClient;
               // tbcID.Text = c.ID_Client.ToString();
                dtpData.Text = r.Data.ToString();
                dtpOra.Text = r.Ora.ToString();
            }
            rFormRez = r;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rFormRez.NumeClient = tbNume.Text;
            rFormRez.Data= dtpData.Value.Date;
            rFormRez.Ora= dtpOra.Value.TimeOfDay;

            if (rFormRez.isValid)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            var mesaj = "";
            foreach (var error in rFormRez.ValidationErrors)
            {
                mesaj += error + "\n";
            }
            if (rFormRez.ValidationErrors.Any())
                MessageBox.Show(mesaj, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
