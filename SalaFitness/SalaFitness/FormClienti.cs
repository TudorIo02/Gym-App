using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Net.WebRequestMethods;

namespace SalaFitness
{
    public partial class FormClienti : Form
    {
        Clienti c1, c2;

        private void adaugaMembruToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clienti c = null;
            MembruNou mb=new MembruNou(c);
            if (mb.ShowDialog() == DialogResult.OK)
            {
                var nrcrt = 0;
                foreach (ListViewItem poz in lvMembrii.Items)
                {
                    var a = Convert.ToInt32(poz.SubItems[0].Text);
                    if (a > nrcrt) nrcrt = a;
                }
                nrcrt++;

                c = mb.mMembriiNoi;
                ListViewItem lv3 = new ListViewItem(new string[]
                    {nrcrt.ToString(),c.Nume,c.Prenume,c.Varsta.ToString(),c.NrTelefon});
                lv3.Tag = c;
                lvMembrii.Items.Add(lv3);
            }
        }

        private void modificaMembruToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvMembrii.SelectedItems.Count > 0)
            {
                Clienti c = lvMembrii.SelectedItems[0].Tag as Clienti;
                MembruNou form = new MembruNou(c);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lv = lvMembrii.SelectedItems[0] as ListViewItem;
                    lv.SubItems[0].Text = c.IdClient.ToString();
                    lv.SubItems[1].Text = c.Nume;
                    lv.SubItems[2].Text = c.Prenume;
                    lv.SubItems[3].Text = c.Varsta.ToString();
                    lv.SubItems[4].Text = c.NrTelefon;
                }
            }
        }

        private void stergeMembruToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvMembrii.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Sigur doresti sa stergi membrul selectat?", "Confirmare",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                    lvMembrii.SelectedItems[0].Remove();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (lvMembrii.SelectedItems.Count > 0)
            {
                modificaMembruToolStripMenuItem.Enabled = true;
                stergeMembruToolStripMenuItem.Enabled = true;
            }
            else
            {
                modificaMembruToolStripMenuItem.Enabled = false;
                stergeMembruToolStripMenuItem.Enabled = false;
            }
        }

        private void adaugaMembruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adaugaMembruToolStripMenuItem1_Click(sender, e);
        }

        private void stergeMembruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stergeMembruToolStripMenuItem1_Click( sender, e);
        }

        private void modificaMembruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificaMembruToolStripMenuItem1_Click( sender , e);
        }

        private void salvareFisierBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = " fisier film (*.flm)|*.flm";
            fd.CheckFileExists = false;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Clienti> lista = new List<Clienti>();
                foreach (ListViewItem lvi in lvMembrii.Items)
                    lista.Add((Clienti)lvi.Tag);
                try
                {
                    BinaryFormatter serializator = new BinaryFormatter();
                    Stream fisier = System.IO.File.Create(fd.FileName);

                    serializator.Serialize(fisier, lista);
                    fisier.Close();
                    MessageBox.Show("Lista de membrii a fost serializata");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void stergereFisierBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere client (*.flm)|*.flm";
            fd.CheckFileExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Clienti> lista = new List<Clienti>();

                Stream fisier = System.IO.File.OpenRead(fd.FileName);
                BinaryFormatter serializator = new BinaryFormatter();
                lista.AddRange((List<Clienti>)serializator.Deserialize(fisier));

                if (lvMembrii.Items.Count > 0)
                {
                    if (MessageBox.Show("Sunt filme in lista. Doriti sa sterg lista existenta?",
                        "Intrebare", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        lvMembrii.Items.Clear();
                }

                foreach (Clienti c in lista)
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                {c.IdClient.ToString(),c.Nume,c.Prenume,c.Varsta.ToString(),c.NrTelefon});
                    lvi.Tag = c;
                    lvMembrii.Items.Add(lvi);
                }
                fisier.Close();
            }
        }

        private void salvareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "salvare xml|*.xml";
            fd.CheckPathExists = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {

                List<Clienti> lista = new List<Clienti>();
                foreach (ListViewItem lvi in lvMembrii.Items)
                    lista.Add((Clienti)lvi.Tag);

                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Clienti>));
                    Stream fisier = System.IO.File.Create(fd.FileName);
                    serializer.Serialize(fisier, lista);
                    MessageBox.Show("Lista de Membrii a fost salvata in format XML!");
                    fisier.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }
        }

        private void stergereXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisier xml |*.xml";
            fd.CheckFileExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream fisier = System.IO.File.OpenRead(fd.FileName);
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Clienti>));
                    List<Clienti> lista = (List<Clienti>)serializer.Deserialize(fisier);
                    if (lvMembrii.Items.Count > 0)
                    {
                        if (MessageBox.Show("Vrei sa stergi inregistrarile existente din lista?",
                            "Intrebare",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                            ) == DialogResult.Yes)
                        {
                            lvMembrii.Items.Clear();
                        }

                    }
                    foreach (Clienti cl in lista)
                    {
                        ListViewItem lvi = new ListViewItem(new String[] {cl.IdClient.ToString(),cl.Nume,cl.Prenume,cl.Varsta.ToString(),cl.NrTelefon
                        });
                        lvi.Tag = cl;
                        lvMembrii.Items.Add(lvi);
                    }
                    fisier.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        public FormClienti()
        {
            InitializeComponent();
            c1 = new Clienti(1, "Pop", "Ana", 20, "0765567899");
            c2 = new Clienti(2, "Manuc", "Paul", 27, "0754432332");

            ListViewItem lv1=new ListViewItem(c1.IdClient.ToString());
            lv1.SubItems.Add(c1.Nume);
            lv1.SubItems.Add(c1.Prenume);
            lv1.SubItems.Add(c1.Varsta.ToString());
            lv1.SubItems.Add(c1.NrTelefon);
            lv1.Tag = c1;
            lvMembrii.Items.Add(lv1);
            ListViewItem lv2=new ListViewItem(c2.IdClient.ToString());
            lv2.SubItems.Add(c2.Nume);
            lv2.SubItems.Add(c2.Prenume);
            lv2.SubItems.Add(c2.Varsta.ToString());
            lv2.SubItems.Add(c2.NrTelefon);
            lv2.Tag = c2;
            lvMembrii.Items.Add(lv2);
        }

       // private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
      //  {
      //  }

    }
}
