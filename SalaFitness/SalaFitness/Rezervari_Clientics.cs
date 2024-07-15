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
    public partial class Rezervari_Clientics : Form
    {   
        Rezervari r1,r2,r3;

        private void modificaRezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvRez.SelectedItems.Count > 0)
            {
                Rezervari r = lvRez.SelectedItems[0].Tag as Rezervari;
                FormRez form = new FormRez(r);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lv = lvRez.SelectedItems[0] as ListViewItem;
                    lv.SubItems[1].Text = r.NumeClient;
                    lv.SubItems[2].Text = r.Data.ToString();
                    lv.SubItems[3].Text = r.Ora.ToString();
                }
            }
        }

        private void stergeRezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvRez.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Sigur doresti sa stergi rezervarea selectata?", "Confirmare",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                    lvRez.SelectedItems[0].Remove();
            }
        }

        private void adaugaRezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezervari r = null;
            FormRez form = new FormRez(r);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var nrcrt = 0;
                foreach (ListViewItem poz in lvRez.Items)
                {
                    var a = Convert.ToInt32(poz.SubItems[0].Text);
                    if (a > nrcrt) nrcrt = a;
                }
                nrcrt++;

                r = form.rFormRez;
                ListViewItem lv3 = new ListViewItem(new string[]
                    {nrcrt.ToString(),r.NumeClient,r.Data.ToString(),r.Ora.ToString()});
                lv3.Tag = r;
                lvRez.Items.Add(lv3);
            }
        }

        private void lvClase_MouseDown(object sender, MouseEventArgs e)
        {
            if (lvClase.SelectedItems.Count > 0)
                lvClase.DoDragDrop((Clasa_aerobic)lvClase.SelectedItems[0].Tag,
                    DragDropEffects.Copy);
        }

      
        private void tvRez_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(new Clasa_aerobic().GetType().ToString()))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        

        private void tvRez_DragDrop(object sender, DragEventArgs e)
        {
            Point punct = new Point(e.X, e.Y);
            Point punctDinTreeview = tvRez.PointToClient(punct);
            TreeNode tn = tvRez.GetNodeAt(punctDinTreeview);

            if (!(tn is null) && e.Effect == DragDropEffects.Copy &&
                 e.Data.GetDataPresent(new Clasa_aerobic().GetType().ToString()))
            {
                Clasa_aerobic ca = (Clasa_aerobic)e.Data.GetData(new Clasa_aerobic().GetType().ToString());
                TreeNode t = new TreeNode(ca.NumeClasa + " " + ca.Durata);
                t.Tag = ca;
                tn.Nodes.Add(t);
                tn.Expand();
            }
        }

        

            public Rezervari_Clientics()
        {
            InitializeComponent();
            r1 = new Rezervari(1, "Apostol Andrei", new DateTime(2024, 6, 27), new TimeSpan(14, 0, 0));
            r2 = new Rezervari(2, "Chiroiu Marcel", new DateTime(2024, 5, 30), new TimeSpan(11, 30, 0));
            r3 = new Rezervari(3, "Licuroiu Denisa", new DateTime(2024, 6, 1), new TimeSpan(13, 30, 0));
           
            ListViewItem lv1= new ListViewItem(r1.IdRezervare.ToString());
            lv1.SubItems.Add(r1.NumeClient);
            lv1.SubItems.Add(r1.Data.ToString());
            lv1.SubItems.Add(r1.Ora.ToString());
            lv1.Tag = r1;
            lvRez.Items.Add(lv1);

            ListViewItem lv2 = new ListViewItem(r2.IdRezervare.ToString());
            lv2.SubItems.Add(r2.NumeClient);
            lv2.SubItems.Add(r2.Data.ToString());
            lv2.SubItems.Add(r2.Ora.ToString());
            lv2.Tag = r2;
            lvRez.Items.Add(lv2);

            ListViewItem lv3 = new ListViewItem(r3.IdRezervare.ToString());
            lv3.SubItems.Add(r3.NumeClient);
            lv3.SubItems.Add(r3.Data.ToString());
            lv3.SubItems.Add(r3.Ora.ToString());
            lv3.Tag = r3;
            lvRez.Items.Add(lv3);

            Clasa_aerobic ca1 = new Clasa_aerobic("Kangoo-Jumps",5,2.5);
            Clasa_aerobic ca2 = new Clasa_aerobic("Pilates",7,1.5);
            Clasa_aerobic ca3 = new Clasa_aerobic("Circuit",9,3);
            Clasa_aerobic ca4 = new Clasa_aerobic("Aerobic",2,1);
            ListViewItem lv4 = new ListViewItem(new string[]
            { ca1.NumeClasa,ca1.NivelGreutate.ToString(),ca1.Durata.ToString()});
            lv4.Tag = ca1;
            lvClase.Items.Add(lv4);

            ListViewItem lv5 = new ListViewItem(new string[]
           { ca2.NumeClasa,ca2.NivelGreutate.ToString(),ca2.Durata.ToString()});
            lv5.Tag = ca2;
            lvClase.Items.Add(lv5);

            ListViewItem lv6 = new ListViewItem(new string[]
           { ca3.NumeClasa,ca3.NivelGreutate.ToString(),ca3.Durata.ToString()});
            lv6.Tag = ca3;
            lvClase.Items.Add(lv6);

            ListViewItem lv7 = new ListViewItem(new string[]
           { ca4.NumeClasa,ca4.NivelGreutate.ToString(),ca4.Durata.ToString()});
            lv7.Tag = ca4;
            lvClase.Items.Add(lv7);

            TreeNode t = new TreeNode(r1.NumeClient + " " + r1.Data.ToString());
            t.Tag = r1;
            tvRez.Nodes.Add(t);

            TreeNode t2 = new TreeNode(r2.NumeClient + " " + r2.Data.ToString());
            t.Tag = r2;
            tvRez.Nodes.Add(t2);
            TreeNode t3 = new TreeNode(r3.NumeClient + " " + r3.Data.ToString());
            t.Tag = r3;
            tvRez.Nodes.Add(t3);
        }
    }
}
