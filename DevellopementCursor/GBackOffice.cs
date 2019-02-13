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
        VueModelePartenaire vpart = new VueModelePartenaire();

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
                    int temp2 = Convert.ToInt32(temp.Substring(0, 2));

                    if (temp2 < 10)
                    {
                        NumCatBox.Text = Convert.ToString(temp2);
                        LibCatbox.Text = vc.Get_LibCategorie(Convert.ToInt32(NumCatBox.Text));
                    }
                    if (temp2 >= 10 && temp2 < 100)
                    {
                        NumCatBox.Text = Convert.ToString(temp2);
                        LibCatbox.Text = vc.Get_LibCategorie(Convert.ToInt32(NumCatBox.Text));
                    }

                }
                if(panelProd.Visible == true)
                {
                    String temp = listcat.SelectedItem.ToString();
                    int temp2 = Convert.ToInt32(temp.Substring(0, 3));
                    catprodbox.Items.Clear();

                    if (temp2 < 10)
                    {
                        temp = temp.Substring(2);
                        libprod.Text = temp.Substring(2);
                        idProdBox.Text = Convert.ToString(temp2);
                        prixprod.Text = Convert.ToString(vp.Get_PrixProd(Convert.ToInt32(idProdBox.Text))) ;
                        descprod.Text = vp.Get_DescProd(Convert.ToInt32(idProdBox.Text));

                        String allid = vc.Get_AllIdCategorie();
                        String[] allidcat = allid.Split(',');

                        foreach (string a in allidcat)
                        {
                            if (a.Length != 0)
                                catprodbox.Items.Add(a + " " + vc.Get_LibCategorie(Convert.ToInt32(a)));
                        }

                        catprodbox.SelectedIndex = Convert.ToInt32(vp.Get_NumCatProd(temp2)) - 1;
                        //vp.Get_NumCatProd(temp2) + " " + vc.Get_LibCategorie(temp2);
                    }
                    if (temp2 >= 10)
                    {
                        libprod.Text = temp.Substring(3);
                        idProdBox.Text = Convert.ToString(temp2);
                        prixprod.Text = Convert.ToString(vp.Get_PrixProd(Convert.ToInt32(idProdBox.Text)));
                        descprod.Text = vp.Get_DescProd(Convert.ToInt32(idProdBox.Text));

                        String allid = vc.Get_AllIdCategorie();
                        String[] allidcat = allid.Split(',');

                        foreach (string a in allidcat)
                        {
                            if (a.Length != 0)
                                catprodbox.Items.Add(a + " " + vc.Get_LibCategorie(Convert.ToInt32(a)));
                        }
                        //catprodbox.SelectedValue = Convert.ToString(temp2);

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

            String oui = vc.Get_AllIdCategorie();
            string[] cha = oui.Split(',');

            foreach (string a in cha)
            {
                if (a.Length != 0)
                {
                    if (Convert.ToInt32(a) < 10)
                        listcat.Items.Add("0" + a + " " + vc.Get_LibCategorie(Convert.ToInt32(a)) );
                    if (Convert.ToInt32(a) >= 10 && Convert.ToInt32(a) < 100)
                        listcat.Items.Add(a + " " + vc.Get_LibCategorie(Convert.ToInt32(a)) );
                }
            }
            panelCat.Visible = true;
            panelProd.Visible = false;
            searchboxprod.Visible = false;
            searchpicprod.Visible = false;
        }

        private void supcat_Click(object sender, EventArgs e)
        {
            vc.Remove_Categorie(Convert.ToInt32(NumCatBox.Text));
            listcat.SelectedIndex--;
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

            String oui = vp.Get_AllIdProd();
            string[] cha = oui.Split(',');

            foreach (string a in cha)
            {
                if (a.Length != 0)
                {
                    if (Convert.ToInt32(a) < 10)
                        listcat.Items.Add("00" + a + " " + vp.Get_LibProd(Convert.ToInt32(a)));
                    if (Convert.ToInt32(a) >= 10 && Convert.ToInt32(a) < 100)
                        listcat.Items.Add("0" + a + " " + vp.Get_LibProd(Convert.ToInt32(a)));
                    if (Convert.ToInt32(a) >= 100 && Convert.ToInt32(a) < 1000)
                        listcat.Items.Add(a + " " + vp.Get_LibProd(Convert.ToInt32(a)));
                }
            }

            panelCat.Visible = false;
            panelProd.Visible = true;
            searchboxprod.Visible = true;
            searchpicprod.Visible = true;
        }

        private void modprod_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(catprodbox.Text.Substring(0, 2)) < 10)
                    vp.Modify_Prod(Convert.ToInt32(idProdBox.Text), Convert.ToInt32(catprodbox.Text.Substring(0, 1)), libprod.Text
                    , Convert.ToSingle(prixprod.Text), descprod.Text);
                else
                    vp.Modify_Prod(Convert.ToInt32(idProdBox.Text), Convert.ToInt32(catprodbox.Text.Substring(0, 2)), libprod.Text
                    , Convert.ToSingle(prixprod.Text), descprod.Text);
            }
            catch (FormatException) { laberrorprod.Visible = true; }

            Refreshprod();
        }

        private void actuprod_Click(object sender, EventArgs e)
        {
            Refreshprod();
        }

        private void supprod_Click(object sender, EventArgs e)
        {
            vp.Remove_Prod(Convert.ToInt32(idProdBox.Text));
            Refreshprod();
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
            if (tabindex.SelectedIndex == 1)
                RefreshPart();
            if (tabindex.SelectedIndex == 0)
                RefreshCli();
                
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String temp = listcli.SelectedItem.ToString();
            int temp2 = Convert.ToInt32(temp.Substring(0,3));
            idclibox.Text = Convert.ToString(temp2);

            nomclibox.Text = vcl.Get_NomClient(Convert.ToInt32(idclibox.Text));
            preclibox.Text = vcl.Get_PrenomClient(Convert.ToInt32(idclibox.Text));
            adrclibox.Text = vcl.Get_AdrClient(Convert.ToInt32(idclibox.Text));
            cpboxcli.Text = vcl.Get_CPClient(Convert.ToInt32(idclibox.Text));
            villeclibox.Text = vcl.Get_VilClient(Convert.ToInt32(idclibox.Text));
            String tcli = vcl.Get_TelClient(Convert.ToInt32(idclibox.Text));
            telclibox.Text = tcli.Substring(0, 2) + " " + tcli.Substring(2, 2) + " " + tcli.Substring(4, 2) + " " + tcli.Substring(6, 2) + " " + tcli.Substring(8, 2);
            emailclibox.Text = vcl.Get_EmailClient(Convert.ToInt32(idclibox.Text));
            naiclibox.Text = vcl.Get_NaiClient(Convert.ToInt32(idclibox.Text));
            loginclibox.Text = vcl.Get_LogClient(Convert.ToInt32(idclibox.Text));
            mdpclibox.Text = vcl.Get_MdpClient(Convert.ToInt32(idclibox.Text));
            cmdpclibox.Text = mdpclibox.Text;
        }

        private void RefreshCli()
        {
            pancli.Visible = true;
            listcli.Items.Clear();

            String oui = vcl.Get_IdAllClient();
            string[] cha = oui.Split(',');

            foreach (string a in cha)
            {
                if(a.Length != 0)
                {
                    if (Convert.ToInt32(a) < 10)
                        listcli.Items.Add("00" + a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)) );
                    if(Convert.ToInt32(a) >= 10 && Convert.ToInt32(a) < 100)
                        listcli.Items.Add("0" + a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)));
                    if(Convert.ToInt32(a) >= 100 && Convert.ToInt32(a) < 1000)
                        listcli.Items.Add(a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)));
                }
                    
            } 
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
                     , tcli.Substring(0, 2) + tcli.Substring(2, 2) + tcli.Substring(4, 2) + tcli.Substring(6, 2) + tcli.Substring(8, 2)
                     , emailclibox.Text,loginclibox.Text, mdpclibox.Text);
                    laberrorcli.Visible = false;
                }
            }
            catch (FormatException) { laberrorcli.Visible = true; }
        }

        private void addcli_Click(object sender, EventArgs e)
        {
            AjoutCli ajcl = new AjoutCli();
            ajcl.ShowDialog();
            RefreshCli();
        }

        private void supcli_Click(object sender, EventArgs e)
        {
            vcl.Remove_Client(Convert.ToInt32(idclibox.Text));
            RefreshCli();
        }

        private void searchboxcli_TextChanged(object sender, EventArgs e)
        {
                listcli.Items.Clear();

                String oui = vcl.Get_IdAllClient();
                string[] cha = oui.Split(',');

                foreach (string a in cha)
                {
                    if (a.Length != 0)
                    {
                        String non = vcl.Get_NomClient(Convert.ToInt32(a)).ToLower();
                        String hey = vcl.Get_PrenomClient(Convert.ToInt32(a)).ToLower();

                        if (Convert.ToInt32(a) < 10 && non.Contains(searchboxcli.Text.ToLower()) || Convert.ToInt32(a) < 10 && hey.Contains(searchboxcli.Text.ToLower()))
                            listcli.Items.Add("00" + a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)));
                        if (Convert.ToInt32(a) >= 10 && Convert.ToInt32(a) < 100 && non.Contains(searchboxcli.Text.ToLower()) || Convert.ToInt32(a) >= 10 && Convert.ToInt32(a) < 100 && hey.Contains(searchboxcli.Text.ToLower()))
                            listcli.Items.Add("0" + a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)));
                        if (Convert.ToInt32(a) >= 100 && Convert.ToInt32(a) < 1000 && non.Contains(searchboxcli.Text.ToLower()) || Convert.ToInt32(a) >= 100 && Convert.ToInt32(a) < 1000 && hey.Contains(searchboxcli.Text.ToLower()))
                            listcli.Items.Add(a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)));
                    }

                }
            
        }

        private void searchboxprod_TextChanged(object sender, EventArgs e)
        {
            listcat.Items.Clear();

            String oui = vp.Get_AllIdProd();
            string[] cha = oui.Split(',');

            foreach (string a in cha)
            {
                if (a.Length != 0)
                {
                    String non = vp.Get_LibProd(Convert.ToInt32(a)).ToLower();

                    if (Convert.ToInt32(a) < 10 && non.Contains(searchboxprod.Text.ToLower()))
                        listcat.Items.Add("00" + a + " " + vp.Get_LibProd(Convert.ToInt32(a)));
                    if (Convert.ToInt32(a) >= 10 && Convert.ToInt32(a) < 100 && non.Contains(searchboxprod.Text.ToLower()))
                        listcat.Items.Add("0" + a + " " + vp.Get_LibProd(Convert.ToInt32(a)));
                    if (Convert.ToInt32(a) >= 100 && Convert.ToInt32(a) < 1000 && non.Contains(searchboxprod.Text.ToLower()))
                        listcat.Items.Add(a + " " + vp.Get_LibProd(Convert.ToInt32(a)));
                }

            }
        }

        private void searchboxpart_TextChanged(object sender, EventArgs e)
        {
            listpart.Items.Clear();

            String oui = vpart.Get_AllIdPart(); ;
            string[] cha = oui.Split(',');

            foreach (string a in cha)
            {
                if (a.Length != 0)
                {
                    String non = vcl.Get_NomClient(Convert.ToInt32(a)).ToLower();
                    String hey = vcl.Get_PrenomClient(Convert.ToInt32(a)).ToLower();

                    if (Convert.ToInt32(a) < 10 && non.Contains(searchboxpart.Text.ToLower()) || Convert.ToInt32(a) < 10 && hey.Contains(searchboxpart.Text.ToLower()))
                        listpart.Items.Add("00" + a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)));
                    if (Convert.ToInt32(a) >= 10 && Convert.ToInt32(a) < 100 && non.Contains(searchboxpart.Text.ToLower()) || Convert.ToInt32(a) >= 10 && Convert.ToInt32(a) < 100 && hey.Contains(searchboxpart.Text.ToLower()))
                        listpart.Items.Add("0" + a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)));
                    if (Convert.ToInt32(a) >= 100 && Convert.ToInt32(a) < 1000 && non.Contains(searchboxpart.Text.ToLower()) || Convert.ToInt32(a) >= 100 && Convert.ToInt32(a) < 1000 && hey.Contains(searchboxpart.Text.ToLower()))
                        listpart.Items.Add(a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)));
                }

            }
        }

        private void RefreshPart()
        {
            listpart.Items.Clear();

            String oui = vpart.Get_AllIdPart();
            string[] cha = oui.Split(',');

            foreach (string a in cha)
            {
                if (a.Length != 0)
                {
                    if (Convert.ToInt32(a) < 10)
                        listpart.Items.Add("00" + a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)));
                    if (Convert.ToInt32(a) >= 10 && Convert.ToInt32(a) < 100)
                        listpart.Items.Add("0" + a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)));
                    if (Convert.ToInt32(a) >= 100 && Convert.ToInt32(a) < 1000)
                        listpart.Items.Add(a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)));
                }
            }
        }

        private void listpart_SelectedIndexChanged(object sender, EventArgs e)
        {
            String temp = listpart.SelectedItem.ToString();
            int temp2 = Convert.ToInt32(temp.Substring(0, 3));
            boxidpart.Text = Convert.ToString(temp2);

            boxnompart.Text = vcl.Get_NomClient(temp2);
            boxprepart.Text = vcl.Get_PrenomClient(temp2);
            boxniv.Text = vpart.Get_Niveau(temp2);
            boxpourc.Text = Convert.ToString(vpart.Get_PourcReduc(temp2));

        }

        private void modpart_Click(object sender, EventArgs e)
        {
            vpart.Set_Niveau(Convert.ToInt32(boxidpart.Text), boxniv.Text);
            vpart.Set_PourcReduc(Convert.ToInt32(boxidpart.Text), Convert.ToInt32(boxpourc.Text));
            RefreshPart();
        }

        private void suppart_Click(object sender, EventArgs e)
        {
            vpart.Remove_Part(Convert.ToInt32(boxidpart.Text));
            RefreshPart();
        }

        private void ajpart_Click(object sender, EventArgs e)
        {
            AjoutPart ajp = new AjoutPart();
            ajp.ShowDialog();
            RefreshPart();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RefreshPart();
        }
    }
}
