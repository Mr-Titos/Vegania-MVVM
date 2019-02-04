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
    public partial class AjoutProd : Form
    {
        VueModeleProduits vp = new VueModeleProduits();
        public AjoutProd()
        {
            InitializeComponent();
            Modele.Donnees db = new Modele.Donnees();
            var produits = from cat in db.categories
                           select cat;

            foreach (var p in produits.ToList())
                comboBox1.Items.Add(p.NUM_CATEGORIE + " " + p.LIB_CATEGORIE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProd();
        }

        private void AddProd()
        {
            String temp = vp.Get_AllLibProd();
            String[] temp2 = temp.Split(',');
            int c = 0;
            for (int a = 0; a < temp2.Length; a++)
            {
                if (ajoutbox.Text == temp2[a])
                    c++;
            }
            if (c == 0)
                vp.Add_Prod(Convert.ToInt32(comboBox1.Text.Substring(0,1)), ajoutbox.Text, Convert.ToDouble(textBox1.Text), textBox2.Text);
            Close();
        }

        private void ajoutbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddProd();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddProd();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddProd();
        }
    }
}
