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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void membruNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienti mn= new FormClienti();
            mn.Show();
        }

        private void rezervariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezervari_Clientics rc= new Rezervari_Clientics();
            rc.Show();
        }

        private void echipamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BazaDeDate_Echipamente bde=new BazaDeDate_Echipamente();
            bde.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Log Out!!! Confirm?","LOG OUT",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
                {
                this.Close();
                Login lg= new Login();
                lg.Show();
            }
        }
    }
}
