using System;
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
    public partial class Maquette : Form
    {
        VueModeleCategorie vc = new VueModeleCategorie();
        VueModeleProduits vp = new VueModeleProduits();
        Modele.Donnees db = new Modele.Donnees();

        public Maquette()
        {
            InitializeComponent();
        }

        private void listclient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Maquette_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Refreshcat();
        }

        private void listcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listcat.SelectedItem != null)
            {
                if (panelCat.Visible == true)
                {
                    String temp = listcat.SelectedItem.ToString();
                    String temp2 = temp.Substring(0, 1);
                    String temp3 = temp.Substring(0, 2);
                    if (Convert.ToInt32(temp2) < 10)
                    {
                        temp = temp.Substring(2);
                        LibCatbox.Text = temp;
                        NumCatBox.Text = temp2;
                    }
                    if (Convert.ToInt32(temp3) >= 10)
                    {
                        LibCatbox.Text = temp.Substring(3);
                        NumCatBox.Text = temp3;
                    }
                }
                if(panelProd.Visible == true)
                {
                    String temp = listcat.SelectedItem.ToString();
                    String temp2 = temp.Substring(0, 1);
                    String temp3 = temp.Substring(0, 2);
                    if (Convert.ToInt32(temp2) < 10)
                    {
                        temp = temp.Substring(2);
                        libprod.Text = temp;
                        idProdBox.Text = temp2;
                        numcatboxprod.Text = Convert.ToString(vp.Get_NumCatProd(Convert.ToInt32(idProdBox.Text)));
                        prixprod.Text = Convert.ToString(vp.Get_PrixProd(Convert.ToInt32(idProdBox.Text))) ;
                        descprod.Text = vp.Get_DescProd(Convert.ToInt32(idProdBox.Text));
                    }
                    if (Convert.ToInt32(temp3) >= 10)
                    {
                        libprod.Text = temp.Substring(3);
                        idProdBox.Text = temp3;
                        numcatboxprod.Text = Convert.ToString(vp.Get_NumCatProd(Convert.ToInt32(idProdBox.Text)));
                        prixprod.Text = Convert.ToString(vp.Get_PrixProd(Convert.ToInt32(idProdBox.Text)));
                        descprod.Text = vp.Get_DescProd(Convert.ToInt32(idProdBox.Text));
                    }
                }

            }

        }

        private void modcat_Click(object sender, EventArgs e)
        {
            vc.Modify_Categorie(Convert.ToInt32(NumCatBox.Text), LibCatbox.Text);
            Refreshcat();
        }

        private void Refreshcat()
        {
            listcat.Items.Clear();
            var produits = from cat in db.categories
                           select cat;

            foreach (var p in produits.ToList())
                listcat.Items.Add(p.NUM_CATEGORIE + " " + p.LIB_CATEGORIE);

            panelCat.Visible = true;
            panelProd.Visible = false;
        }

        private void supcat_Click(object sender, EventArgs e)
        {
            vc.Remove_Categorie(Convert.ToInt32(NumCatBox.Text));
            Refreshcat();
        }

        private void ajcat_Click(object sender, EventArgs e)
        {
            AjoutCat ajc = new AjoutCat();
            ajc.ShowDialog();
            Refreshcat();
        }

        //Partie Produits

        private void Refreshprod()
        {
            listcat.Items.Clear();
            var produits = from cat in db.produits
                           select cat;

            foreach (var p in produits.ToList())
                listcat.Items.Add(p.IdProd + " " + p.LibProd);

            panelCat.Visible = false;
            panelProd.Visible = true;
        }

        private void modprod_Click(object sender, EventArgs e)
        {
            vc.Modify_Categorie(Convert.ToInt32(NumCatBox.Text), LibCatbox.Text);
            Refreshprod();
        }

        private void actuprod_Click(object sender, EventArgs e)
        {
            Refreshprod();
        }

        private void supprod_Click(object sender, EventArgs e)
        {
            vp.Remove_Prod(Convert.ToInt32(idProdBox.Text));
            Refreshcat();
        }

        private void ajprod_Click(object sender, EventArgs e)
        {
            AjoutProd ap = new AjoutProd();
            ap.ShowDialog();
            Refreshprod();
        }
    }
}
