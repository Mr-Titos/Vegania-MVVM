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
    public partial class AjoutCat : Form
    {
        VueModeleCategorie vc = new VueModeleCategorie();

        public AjoutCat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String temp = vc.Get_AllCategorie();
            String[] temp2 = temp.Split(',');
            int c = 0;
            for (int a = 0; a < temp2.Length; a++)
            {
                if (ajoutbox.Text == temp2[a])
                    c++;
            }
            if (c == 0)
                vc.Add_Categorie(ajoutbox.Text);
            Close();
        }

        private void ajoutbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                String temp = vc.Get_AllCategorie();
                String[] temp2 = temp.Split(',');
                int c = 0;
                for (int a = 0; a < temp2.Length; a++)
                {
                    if (ajoutbox.Text == temp2[a])
                        c++;
                }
                if (c == 0)
                    vc.Add_Categorie(ajoutbox.Text);
                Close();
            }
        }
    }
}
