﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if( tbUsr.Text=="admin"&&tbPsw.Text=="admin")
            {
                Form1 fm=new Form1();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Parola sau Username incorecte!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
