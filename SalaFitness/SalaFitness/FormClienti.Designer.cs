namespace SalaFitness
{
    partial class FormClienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClienti));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareFisierBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereFisierBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaMembruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeMembruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaMembruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvMembrii = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVarsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adaugaMembruToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaMembruToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeMembruToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisiereToolStripMenuItem,
            this.adaugaMembruToolStripMenuItem1,
            this.modificaMembruToolStripMenuItem1,
            this.stergeMembruToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1222, 77);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareFisierBinarToolStripMenuItem,
            this.stergereFisierBinarToolStripMenuItem,
            this.salvareXMLToolStripMenuItem,
            this.stergereXMLToolStripMenuItem});
            this.fisiereToolStripMenuItem.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fisiereToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fisiereToolStripMenuItem.Image")));
            this.fisiereToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(153, 73);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // salvareFisierBinarToolStripMenuItem
            // 
            this.salvareFisierBinarToolStripMenuItem.Name = "salvareFisierBinarToolStripMenuItem";
            this.salvareFisierBinarToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.salvareFisierBinarToolStripMenuItem.Text = "Salvare fisier binar";
            this.salvareFisierBinarToolStripMenuItem.Click += new System.EventHandler(this.salvareFisierBinarToolStripMenuItem_Click);
            // 
            // stergereFisierBinarToolStripMenuItem
            // 
            this.stergereFisierBinarToolStripMenuItem.Name = "stergereFisierBinarToolStripMenuItem";
            this.stergereFisierBinarToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.stergereFisierBinarToolStripMenuItem.Text = "Restaurare fisier binar";
            this.stergereFisierBinarToolStripMenuItem.Click += new System.EventHandler(this.stergereFisierBinarToolStripMenuItem_Click);
            // 
            // salvareXMLToolStripMenuItem
            // 
            this.salvareXMLToolStripMenuItem.Name = "salvareXMLToolStripMenuItem";
            this.salvareXMLToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.salvareXMLToolStripMenuItem.Text = "Salvare XML";
            this.salvareXMLToolStripMenuItem.Click += new System.EventHandler(this.salvareXMLToolStripMenuItem_Click);
            // 
            // stergereXMLToolStripMenuItem
            // 
            this.stergereXMLToolStripMenuItem.Name = "stergereXMLToolStripMenuItem";
            this.stergereXMLToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.stergereXMLToolStripMenuItem.Text = "Restaurare XML";
            this.stergereXMLToolStripMenuItem.Click += new System.EventHandler(this.stergereXMLToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaMembruToolStripMenuItem,
            this.stergeMembruToolStripMenuItem,
            this.modificaMembruToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 76);
            // 
            // adaugaMembruToolStripMenuItem
            // 
            this.adaugaMembruToolStripMenuItem.Name = "adaugaMembruToolStripMenuItem";
            this.adaugaMembruToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.adaugaMembruToolStripMenuItem.Text = "Adauga membru";
            this.adaugaMembruToolStripMenuItem.Click += new System.EventHandler(this.adaugaMembruToolStripMenuItem_Click);
            // 
            // stergeMembruToolStripMenuItem
            // 
            this.stergeMembruToolStripMenuItem.Name = "stergeMembruToolStripMenuItem";
            this.stergeMembruToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.stergeMembruToolStripMenuItem.Text = "Sterge membru";
            this.stergeMembruToolStripMenuItem.Click += new System.EventHandler(this.stergeMembruToolStripMenuItem_Click);
            // 
            // modificaMembruToolStripMenuItem
            // 
            this.modificaMembruToolStripMenuItem.Name = "modificaMembruToolStripMenuItem";
            this.modificaMembruToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.modificaMembruToolStripMenuItem.Text = "Modifica membru";
            this.modificaMembruToolStripMenuItem.Click += new System.EventHandler(this.modificaMembruToolStripMenuItem_Click);
            // 
            // lvMembrii
            // 
            this.lvMembrii.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lvMembrii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chNume,
            this.chPrenume,
            this.chVarsta,
            this.chTelefon});
            this.lvMembrii.ContextMenuStrip = this.contextMenuStrip1;
            this.lvMembrii.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMembrii.FullRowSelect = true;
            this.lvMembrii.HideSelection = false;
            this.lvMembrii.Location = new System.Drawing.Point(311, 137);
            this.lvMembrii.Name = "lvMembrii";
            this.lvMembrii.Size = new System.Drawing.Size(584, 325);
            this.lvMembrii.TabIndex = 2;
            this.lvMembrii.UseCompatibleStateImageBehavior = false;
            this.lvMembrii.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 76;
            // 
            // chNume
            // 
            this.chNume.Text = "Nume";
            this.chNume.Width = 114;
            // 
            // chPrenume
            // 
            this.chPrenume.Text = "Prenume";
            this.chPrenume.Width = 117;
            // 
            // chVarsta
            // 
            this.chVarsta.Text = "Varsta";
            this.chVarsta.Width = 82;
            // 
            // chTelefon
            // 
            this.chTelefon.Text = "Telefon";
            this.chTelefon.Width = 151;
            // 
            // adaugaMembruToolStripMenuItem1
            // 
            this.adaugaMembruToolStripMenuItem1.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaMembruToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("adaugaMembruToolStripMenuItem1.Image")));
            this.adaugaMembruToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adaugaMembruToolStripMenuItem1.Name = "adaugaMembruToolStripMenuItem1";
            this.adaugaMembruToolStripMenuItem1.Size = new System.Drawing.Size(232, 73);
            this.adaugaMembruToolStripMenuItem1.Text = "Adauga membru";
            this.adaugaMembruToolStripMenuItem1.Click += new System.EventHandler(this.adaugaMembruToolStripMenuItem1_Click);
            // 
            // modificaMembruToolStripMenuItem1
            // 
            this.modificaMembruToolStripMenuItem1.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaMembruToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("modificaMembruToolStripMenuItem1.Image")));
            this.modificaMembruToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.modificaMembruToolStripMenuItem1.Name = "modificaMembruToolStripMenuItem1";
            this.modificaMembruToolStripMenuItem1.Size = new System.Drawing.Size(243, 73);
            this.modificaMembruToolStripMenuItem1.Text = "Modifica membru";
            this.modificaMembruToolStripMenuItem1.Click += new System.EventHandler(this.modificaMembruToolStripMenuItem1_Click);
            // 
            // stergeMembruToolStripMenuItem1
            // 
            this.stergeMembruToolStripMenuItem1.Font = new System.Drawing.Font("Imprint MT Shadow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergeMembruToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stergeMembruToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("stergeMembruToolStripMenuItem1.Image")));
            this.stergeMembruToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stergeMembruToolStripMenuItem1.Name = "stergeMembruToolStripMenuItem1";
            this.stergeMembruToolStripMenuItem1.Size = new System.Drawing.Size(222, 73);
            this.stergeMembruToolStripMenuItem1.Text = "Sterge membru";
            this.stergeMembruToolStripMenuItem1.Click += new System.EventHandler(this.stergeMembruToolStripMenuItem1_Click);
            // 
            // FormClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1222, 597);
            this.Controls.Add(this.lvMembrii);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormClienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClienti";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareFisierBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereFisierBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereXMLToolStripMenuItem;
        private System.Windows.Forms.ListView lvMembrii;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chPrenume;
        private System.Windows.Forms.ColumnHeader chVarsta;
        private System.Windows.Forms.ColumnHeader chTelefon;
        private System.Windows.Forms.ToolStripMenuItem adaugaMembruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeMembruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaMembruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaMembruToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificaMembruToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergeMembruToolStripMenuItem1;
    }
}