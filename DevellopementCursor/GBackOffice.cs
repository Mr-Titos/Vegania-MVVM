using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        VueModeleClient vcl = new VueModeleClient();
        Modele.Donnees db = new Modele.Donnees();

        public Maquette()
        {
            InitializeComponent();
        }

        private void Maquette_Load(object sender, EventArgs e)
        {
            RefreshCli();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pancli.Visible = true;
            RefreshCli();
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

        private void tabindex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabindex.SelectedIndex == 2)
                Refreshprod();
            /*if(tabindex.SelectedIndex == 1)
            */
            if (tabindex.SelectedIndex == 0)
                RefreshCli();
                
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String temp = listcli.SelectedItem.ToString();
            int salt = 0;

            if (Convert.ToInt32(temp.Substring(0, 1)) < 10 && salt == 0)
            {
                idclibox.Text = temp.Substring(0, 1);
                salt = 1;
            }
            if (salt == 0)
            {
                if (Convert.ToInt32(temp.Substring(0, 2)) >= 10 && Convert.ToInt32(temp.Substring(0, 2)) < 100 && salt == 0)
                    idclibox.Text = temp.Substring(0, 2);
                salt = 10;
            }

            if (salt == 0)
            {
                if (Convert.ToInt32(temp.Substring(0, 3)) >= 100 && Convert.ToInt32(temp.Substring(0, 3)) < 1000)
                    idclibox.Text = temp.Substring(0, 3);
                salt = 100;
            }

            nomclibox.Text = vcl.Get_NomClient(Convert.ToInt32(idclibox.Text));
            preclibox.Text = vcl.Get_PrenomClient(Convert.ToInt32(idclibox.Text));
            adrclibox.Text = vcl.Get_AdrClient(Convert.ToInt32(idclibox.Text));
            cpboxcli.Text = vcl.Get_CPClient(Convert.ToInt32(idclibox.Text));
            villeclibox.Text = vcl.Get_VilClient(Convert.ToInt32(idclibox.Text));
            String tcli = vcl.Get_TelClient(Convert.ToInt32(idclibox.Text));
            telclibox.Text = tcli.Substring(0, 2) + " " + tcli.Substring(2, 2) + " " + tcli.Substring(4, 2) + " " + tcli.Substring(6, 2) + " " + tcli.Substring(8, 2);
            emailclibox.Text = vcl.Get_EmailClient(Convert.ToInt32(idclibox.Text));
            naiclibox.Text = vcl.Get_NaiClient(Convert.ToInt32(idclibox.Text));
            partclibox.Text = Convert.ToString(vcl.Get_PartClient(Convert.ToInt32(idclibox.Text)));
            loginclibox.Text = vcl.Get_LogClient(Convert.ToInt32(idclibox.Text));
            mdpclibox.Text = vcl.Get_MdpClient(Convert.ToInt32(idclibox.Text));
            salt = 0;
        }

        private void RefreshCli()
        {
            pancli.Visible = true;

            listcli.Items.Clear();
            var cli = from cat in db.clients
                           select cat;

            foreach (var p in cli.ToList())
                listcli.Items.Add(p.NUM_CLIENT + " " + p.PRE_CLIENT + " " + p.NOM_CLIENT);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (mdpclibox.UseSystemPasswordChar == true)
                mdpclibox.UseSystemPasswordChar = false;
            else if (mdpclibox.UseSystemPasswordChar == false)
                mdpclibox.UseSystemPasswordChar = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (cmdpclibox.UseSystemPasswordChar == true)
                cmdpclibox.UseSystemPasswordChar = false;
            else if (cmdpclibox.UseSystemPasswordChar == false)
                cmdpclibox.UseSystemPasswordChar = true;
        }

        private void modcli_Click(object sender, EventArgs e)
        {
            try
            {
                if (mdpclibox.Text == cmdpclibox.Text)
                {
                    String tcli = vcl.Get_TelClient(Convert.ToInt32(idclibox.Text));
                    vcl.Modify_Client(Convert.ToInt32(idclibox.Text), nomclibox.Text, preclibox.Text, adrclibox.Text, cpboxcli.Text, villeclibox.Text, naiclibox.Text
                     , tcli.Substring(0, 2) + tcli.Substring(3, 2) + tcli.Substring(5, 2) + tcli.Substring(7, 2) + tcli.Substring(9, 2)
                     , emailclibox.Text, Convert.ToBoolean(partcli), loginclibox.Text, mdpclibox.Text);
                    laberrorcli.Visible = false;
                }
            }
            catch (FormatException) { laberrorcli.Visible = true; }
        }

        private void addcli_Click(object sender, EventArgs e)
        {

        }
    }
}
