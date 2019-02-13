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
    public partial class AjoutCli : Form
    {
        VueModeleClient vcl = new VueModeleClient();

        public AjoutCli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCli();
        }

        private void AddCli()
        {
            try
            {
               if (nomclibox.Text.Length < 100 && cpboxcli.Text.Length == 5 && telclibox.Text.Length == 10 && loginclibox.Text.Length < 100 && mdpclibox.Text.Length < 100)
               {

                    vcl.Add_Client(preclibox.Text, nomclibox.Text, adrclibox.Text, cpboxcli.Text
                   , villeclibox.Text, naiclibox.Text, telclibox.Text, emailclibox.Text
                   , loginclibox.Text, mdpclibox.Text);
                    laberrorcli.Visible = false;
               }
                else
                    laberrorcli.Visible = true;
            }
            catch (FormatException) { laberrorcli.Visible = true; laberrorcli.Text = "format exception"; }
            if (laberrorcli.Visible == false)
                Close();
        }
    }
}
