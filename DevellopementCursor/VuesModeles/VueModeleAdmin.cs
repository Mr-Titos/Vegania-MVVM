using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevellopementCursor
{
    class VueModeleAdmin
    {
        Modele.Donnees db = new Modele.Donnees();

        public String get_adminLogin(int n)
        {
            var admin = from cat in db.admin
                          where cat.IdAdmin == n
                          select cat;
            return admin.ToList()[0].Login;
        }

        public String get_adminMdp(int n)
        {
            var admin = from cat in db.admin
                        where cat.IdAdmin == n
                        select cat;
            return admin.ToList()[0].Mdp;
        }
    }
}
