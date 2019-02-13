using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevellopementCursor
{
    public partial class AjoutPart : Form
    {
        VueModeleClient vcl = new VueModeleClient();
        VueModelePartenaire vpart = new VueModelePartenaire();

        public AjoutPart()
        {
            InitializeComponent();

            foreach (string a in vcl.Get_IdAllClient().Split(','))
            {
                if (a.Length != 0)
                {
                    int w = 0;
                    foreach (string c in vpart.Get_AllIdPart().Split(','))
                    {
                        if (a == c)
                            w = 1;
                    }
                    if (w == 0)
                    {
                        if(Convert.ToInt32(a) < 10)
                            comboBox1.Items.Add("00" + a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)));
                        if(Convert.ToInt32(a) < 100 && Convert.ToInt32(a) > 9)
                            comboBox1.Items.Add("0" + a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)));
                        if (Convert.ToInt32(a) < 1000 && Convert.ToInt32(a) > 99)
                            comboBox1.Items.Add(a + " " + vcl.Get_NomClient(Convert.ToInt32(a)) + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)));
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            try
            {
                vpart.Add_Partenaire(Convert.ToInt32(comboBox1.GetItemText(comboBox1.SelectedItem).Substring(0, 3)), boxniv.Text, Convert.ToInt32(boxreduc.Text));
                Close();
            }
            catch (Exception) { duplicata.Visible = true; }
            }

        private void boxniv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Add();
        }

        private void boxreduc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Add();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            String oui = vcl.Get_IdAllClient();
            string[] cha = oui.Split(',');

            foreach (string a in cha)
            {
                if (a.Length != 0)
                {
                    String non = vcl.Get_NomClient(Convert.ToInt32(a)).ToLower();
                    String hey = vcl.Get_PrenomClient(Convert.ToInt32(a)).ToLower();
                    int w = 0;
                    foreach (string c in vpart.Get_AllIdPart().Split(','))
                    {
                        if (a == c)
                            w = 1;
                    }
                    if (w == 0)
                    {

                        if (Convert.ToInt32(a) < 10 && non.Contains(searchboxpart.Text.ToLower()) || Convert.ToInt32(a) < 10 && hey.Contains(searchboxpart.Text.ToLower()))
                            comboBox1.Items.Add("00" + a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)));
                        if (Convert.ToInt32(a) >= 10 && Convert.ToInt32(a) < 100 && non.Contains(searchboxpart.Text.ToLower()) || Convert.ToInt32(a) >= 10 && Convert.ToInt32(a) < 100 && hey.Contains(searchboxpart.Text.ToLower()))
                            comboBox1.Items.Add("0" + a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)));
                        if (Convert.ToInt32(a) >= 100 && Convert.ToInt32(a) < 1000 && non.Contains(searchboxpart.Text.ToLower()) || Convert.ToInt32(a) >= 100 && Convert.ToInt32(a) < 1000 && hey.Contains(searchboxpart.Text.ToLower()))
                            comboBox1.Items.Add(a + " " + vcl.Get_PrenomClient(Convert.ToInt32(a)) + " " + vcl.Get_NomClient(Convert.ToInt32(a)));
                    }
                }

            }
        }
    }
}
