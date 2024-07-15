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
    public partial class MembruNou : Form
    {
        public Clienti mMembriiNoi;
        public MembruNou(Clienti c)
        {
            InitializeComponent();
            if(c == null ) 
            { 
                c= new Clienti();
                c.IdClient = 0;
                adaugabutton.Text = "Adauga";
            }
            else
            {
                adaugabutton.Text = "Editeaza";
                //tbID.Text = c.IdClient.ToString();
                tbNume.Text= c.Nume;
                tbPrenume.Text= c.Prenume;
                tbVarsta.Text= c.Varsta.ToString();
                tbTelefon.Text = c.NrTelefon;
            }
            mMembriiNoi = c;
        }

        private void adaugabutton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    mMembriiNoi.IdClient = Convert.ToInt32(tbID.Text);
            //}
            //catch (Exception)
            //{
            //    mMembriiNoi.IdClient = 0;
            //}
            mMembriiNoi.Nume = tbNume.Text;
            mMembriiNoi.Prenume= tbPrenume.Text;
          
            try
            {
                mMembriiNoi.Varsta = Convert.ToInt32(tbVarsta.Text);
            }
            catch(Exception) 
            { 
                mMembriiNoi.Varsta = 0; 
            }
            mMembriiNoi.NrTelefon = tbTelefon.Text;
            if (mMembriiNoi.isValid)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            var mesaj = "";
            foreach (var error in mMembriiNoi.ValidationErrors)
            {
                mesaj += error + "\n";
            }
            if (mMembriiNoi.ValidationErrors.Any())
                MessageBox.Show(mesaj, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }

        //private void radioButton3_CheckedChanged(object sender, EventArgs e)
        //  {
        // }

    }
}
