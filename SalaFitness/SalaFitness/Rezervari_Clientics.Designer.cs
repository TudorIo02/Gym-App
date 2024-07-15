namespace SalaFitness
{
    partial class Rezervari_Clientics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezervari_Clientics));
            this.lvRez = new System.Windows.Forms.ListView();
            this.lvClase = new System.Windows.Forms.ListView();
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNvl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDurata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chid_cl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chnume_cl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_ora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvRez = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaRezervareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaRezervareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeRezervareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvRez
            // 
            this.lvRez.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lvRez.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chid_cl,
            this.chnume_cl,
            this.chdata,
            this.ch_ora});
            this.lvRez.ContextMenuStrip = this.contextMenuStrip1;
            this.lvRez.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRez.HideSelection = false;
            this.lvRez.Location = new System.Drawing.Point(35, 43);
            this.lvRez.Name = "lvRez";
            this.lvRez.Size = new System.Drawing.Size(526, 267);
            this.lvRez.TabIndex = 0;
            this.lvRez.UseCompatibleStateImageBehavior = false;
            this.lvRez.View = System.Windows.Forms.View.Details;
            // 
            // lvClase
            // 
            this.lvClase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lvClase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNume,
            this.chNvl,
            this.chDurata});
            this.lvClase.Font = new System.Drawing.Font("Imprint MT Shadow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvClase.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lvClase.FullRowSelect = true;
            this.lvClase.HideSelection = false;
            this.lvClase.Location = new System.Drawing.Point(662, 43);
            this.lvClase.Name = "lvClase";
            this.lvClase.Size = new System.Drawing.Size(414, 267);
            this.lvClase.TabIndex = 1;
            this.lvClase.UseCompatibleStateImageBehavior = false;
            this.lvClase.View = System.Windows.Forms.View.Details;
            this.lvClase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvClase_MouseDown);
            // 
            // chNume
            // 
            this.chNume.Text = "Nume clasa";
            this.chNume.Width = 142;
            // 
            // chNvl
            // 
            this.chNvl.Text = "Nivel Greutate";
            this.chNvl.Width = 113;
            // 
            // chDurata
            // 
            this.chDurata.Text = "Durata";
            this.chDurata.Width = 79;
            // 
            // chid_cl
            // 
            this.chid_cl.Text = "ID client";
            this.chid_cl.Width = 83;
            // 
            // chnume_cl
            // 
            this.chnume_cl.Text = "Nume client";
            this.chnume_cl.Width = 120;
            // 
            // chdata
            // 
            this.chdata.Text = "Data";
            this.chdata.Width = 117;
            // 
            // ch_ora
            // 
            this.ch_ora.Text = "Ora";
            this.ch_ora.Width = 96;
            // 
            // tvRez
            // 
            this.tvRez.AllowDrop = true;
            this.tvRez.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tvRez.CheckBoxes = true;
            this.tvRez.Location = new System.Drawing.Point(300, 333);
            this.tvRez.Name = "tvRez";
            this.tvRez.Size = new System.Drawing.Size(352, 198);
            this.tvRez.TabIndex = 2;
            this.tvRez.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvRez_DragDrop);
            this.tvRez.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvRez_DragEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaRezervareToolStripMenuItem,
            this.modificaRezervareToolStripMenuItem,
            this.stergeRezervareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(233, 76);
            // 
            // adaugaRezervareToolStripMenuItem
            // 
            this.adaugaRezervareToolStripMenuItem.Name = "adaugaRezervareToolStripMenuItem";
            this.adaugaRezervareToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.adaugaRezervareToolStripMenuItem.Text = "Adauga rezervare";
            this.adaugaRezervareToolStripMenuItem.Click += new System.EventHandler(this.adaugaRezervareToolStripMenuItem_Click);
            // 
            // modificaRezervareToolStripMenuItem
            // 
            this.modificaRezervareToolStripMenuItem.Name = "modificaRezervareToolStripMenuItem";
            this.modificaRezervareToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.modificaRezervareToolStripMenuItem.Text = "Modifica rezervare";
            this.modificaRezervareToolStripMenuItem.Click += new System.EventHandler(this.modificaRezervareToolStripMenuItem_Click);
            // 
            // stergeRezervareToolStripMenuItem
            // 
            this.stergeRezervareToolStripMenuItem.Name = "stergeRezervareToolStripMenuItem";
            this.stergeRezervareToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.stergeRezervareToolStripMenuItem.Text = "Sterge rezervare";
            this.stergeRezervareToolStripMenuItem.Click += new System.EventHandler(this.stergeRezervareToolStripMenuItem_Click);
            // 
            // Rezervari_Clientics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1117, 553);
            this.Controls.Add(this.tvRez);
            this.Controls.Add(this.lvClase);
            this.Controls.Add(this.lvRez);
            this.DoubleBuffered = true;
            this.Name = "Rezervari_Clientics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervari_Clientics";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvRez;
        private System.Windows.Forms.ListView lvClase;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chNvl;
        private System.Windows.Forms.ColumnHeader chDurata;
        private System.Windows.Forms.ColumnHeader chid_cl;
        private System.Windows.Forms.ColumnHeader chnume_cl;
        private System.Windows.Forms.ColumnHeader chdata;
        private System.Windows.Forms.ColumnHeader ch_ora;
        private System.Windows.Forms.TreeView tvRez;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaRezervareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaRezervareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeRezervareToolStripMenuItem;
    }
}