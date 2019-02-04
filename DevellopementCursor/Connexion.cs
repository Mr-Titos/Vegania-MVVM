﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevellopementCursor
{
    public partial class Connexion : Form
    {
        private bool conx = false;

        public Connexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valider();
        }

        private void mdpbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                valider();
        }


        private void loginbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                valider();
        }

        private void valider()
        {
            VueModeleAdmin vma = new VueModeleAdmin();
            int ab = 0;
            for (int i = 1; i <= 2; i++)
            {
                String a = vma.get_adminLogin(i);
                String b = vma.get_adminMdp(i);
                if (ab == 0)
                {
                    if (loginbox.Text == a && mdpbox.Text == b)
                    {
                        this.conx = true;
                        Visible = false;
                        i = 9999;
                    }
                    else
                    {
                        if (ab != 0)
                        {
                            errorlabel.Visible = true;
                            loginbox.Clear();
                            mdpbox.Clear();
                            loginbox.Focus();
                        }
                    }
                }
            }
        }

        private void Connexion_FormClosing(object sender, FormClosingEventArgs e)
        {
          /* if(conx == true)
            {
                Maquette m = new Maquette();
                m.ShowDialog();
            } */ 
        }
        private void Connexion_VisibleChanged(object sender, EventArgs e)
        {
            if (conx == true)
            {
                Maquette m = new Maquette();
                m.ShowDialog();
                Close();
            }
        }
    }
}