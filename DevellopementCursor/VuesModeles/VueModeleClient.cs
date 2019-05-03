using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevellopementCursor
{
    class VueModeleClient
    {
        Modele.Donnees db = new Modele.Donnees();

        private String test = "";

        public void Add_Client(String pre, String nom, String adr, String cp, String v, String nai, String tel, String email, String log, String mdp)
        {
            // nai doit etre sous le format DD/MM/YYYY
            nai = nai.Substring(6) + "-" + nai.Substring(3, 2) + "-" + nai.Substring(0, 2);

            DateTime dnai = Convert.ToDateTime(nai);
            db.clients.Add(new Modele.clients() { PRE_CLIENT = pre, NOM_CLIENT = nom, ADR_CLIENT = adr, CP_CLIENT = cp, VIL_CLIENT = v, NAI_CLIENT = dnai, TEL_CLIENT = tel, EMAIL_CLIENT = email, LOG_CLIENT = log, MDP_CLIENT = mdp });
            try { db.SaveChanges(); }

            catch ( DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        this.test += ("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
        }
        // DEBUT GET
        public String Get_Test()
        {
            return this.test;
        }

        public String Get_IdAllClient()
        {
            //Selectionner toutes les catégories
            var cli = from cat in db.clients
                           select cat;
            string result = "";
            foreach (var p in cli.ToList())
            {
                result += "," + p.NUM_CLIENT ;
            }
            return result;
        }

        public int Get_IdClient(String n)
        {
            var cli = from cat in db.clients
                      where cat.NOM_CLIENT == n
                      select cat;
            return cli.ToList()[0].NUM_CLIENT;
        }

        public string Get_NomClient(int n)
        {
            var cli = from cat in db.clients
                          where cat.NUM_CLIENT == n
                          select cat;
            return cli.ToList()[0].NOM_CLIENT;
        }

        public string Get_PrenomClient(int n)
        {
            var cli = from cat in db.clients
                      where cat.NUM_CLIENT == n
                      select cat;
            return cli.ToList()[0].PRE_CLIENT;
        }
        public string Get_AdrClient(int n)
        {
            var cli = from cat in db.clients
                          where cat.NUM_CLIENT == n
                          select cat;
            return cli.ToList()[0].ADR_CLIENT;
        }

        public string Get_CPClient(int n)
        {
            var cli = from cat in db.clients
                          where cat.NUM_CLIENT == n
                          select cat;
            return cli.ToList()[0].CP_CLIENT;
        }

        public string Get_VilClient(int n)
        {
            var cli = from cat in db.clients
                          where cat.NUM_CLIENT == n
                          select cat;
            return cli.ToList()[0].VIL_CLIENT;
        }

        public string Get_NaiClient(int n)
        {
            var cli = from cat in db.clients
                      where cat.NUM_CLIENT == n
                      select cat;
            String naiclibox = Convert.ToString(cli.ToList()[0].NAI_CLIENT).Substring(0, 10);
            //String convertdate = naiclibox.Substring(0, 2) + "-" + naiclibox.Substring(3, 2) + "-" + naiclibox.Substring(6, 4);

            return naiclibox;
        }

        public string Get_TelClient(int n)
        {
            var cli = from cat in db.clients
                      where cat.NUM_CLIENT == n
                      select cat;
            return cli.ToList()[0].TEL_CLIENT;
        }

        public string Get_EmailClient(int n)
        {
            var cli = from cat in db.clients
                      where cat.NUM_CLIENT == n
                      select cat;
            return cli.ToList()[0].EMAIL_CLIENT;
        }

        public string Get_LogClient(int n)
        {
            var cli = from cat in db.clients
                      where cat.NUM_CLIENT == n
                      select cat;
            return cli.ToList()[0].LOG_CLIENT;
        }

        public string Get_MdpClient(int n)
        {
            var cli = from cat in db.clients
                      where cat.NUM_CLIENT == n
                      select cat;
            return cli.ToList()[0].MDP_CLIENT;
        }

        public String Get_AllClients()
        {
            var cli = from cat in db.clients
                           select cat;
            string result = "";
            foreach (var p in cli.ToList())
            {
                result += p.NOM_CLIENT + " ";
            }
            return result;
        }
        // FIN GET

        // DEBUT SET
        public void Modify_AdrClient(int n, String m)
        {
            var modif_cli = from cat in db.clients
                            where cat.NUM_CLIENT == n
                            select cat;

            modif_cli.ToList().Last<Modele.clients>().ADR_CLIENT = m;
            db.SaveChanges();
        }

        public void Modify_NomClient(int n, String m)
        {
            var modif_cli = from cat in db.clients
                            where cat.NUM_CLIENT == n
                            select cat;

            modif_cli.ToList().Last<Modele.clients>().NOM_CLIENT = m;
            db.SaveChanges();
        }

        public void Modify_NaiClient(int n, String m)
        {
            // m doit etre sous la forme YYY-MM-DD
            var modif_cli = from cat in db.clients
                            where cat.NUM_CLIENT == n
                            select cat;
            DateTime date = Convert.ToDateTime(m);
            modif_cli.ToList().Last<Modele.clients>().NAI_CLIENT = date;
            db.SaveChanges();
        }

        public void Modify_TelClient(int n, String m)
        {
            var modif_cli = from cat in db.clients
                            where cat.NUM_CLIENT == n
                            select cat;

            modif_cli.ToList().Last<Modele.clients>().TEL_CLIENT = m;
            db.SaveChanges();
        }

        public void Modify_EmailClient(int n, String m)
        {
            var modif_cli = from cat in db.clients
                            where cat.NUM_CLIENT == n
                            select cat;

            modif_cli.ToList().Last<Modele.clients>().EMAIL_CLIENT = m;
            db.SaveChanges();
        }

        public void Modify_CPClient(int n, String m)
        {
            var modif_cli = from cat in db.clients
                            where cat.NUM_CLIENT == n
                            select cat;

            modif_cli.ToList().Last<Modele.clients>().CP_CLIENT = m;
            db.SaveChanges();
        }

        public void Modify_VilleClient(int n, String m)
        {
            var modif_cli = from cat in db.clients
                            where cat.NUM_CLIENT == n
                            select cat;

            modif_cli.ToList().Last<Modele.clients>().VIL_CLIENT = m;
            db.SaveChanges();
        }

        public void Modify_LogClient(int n, String m)
        {
            var modif_cli = from cat in db.clients
                            where cat.NUM_CLIENT == n
                            select cat;

            modif_cli.ToList().Last<Modele.clients>().LOG_CLIENT = m;
            db.SaveChanges();
        }

        public void Modify_MdpClient(int n, String m)
        {
            var modif_cli = from cat in db.clients
                            where cat.NUM_CLIENT == n
                            select cat;

            modif_cli.ToList().Last<Modele.clients>().MDP_CLIENT = m;
            db.SaveChanges();
        }

        public void Modify_Client(int n, String nom, String pnom, String adr, String cp, String v,String nai, String tel, String email, String log, String mdp)
        {
            // nai doit etre sous format DD/MM/YYYY
            var modif_cli = from cat in db.clients
                            where cat.NUM_CLIENT == n
                            select cat;
            nai = nai.Substring(6, 4) + "-" + nai.Substring(3, 2) + "-" + nai.Substring(0, 2);
            DateTime date = Convert.ToDateTime(nai);

            modif_cli.ToList().Last<Modele.clients>().NOM_CLIENT = nom;
            modif_cli.ToList().Last<Modele.clients>().PRE_CLIENT = pnom;
            modif_cli.ToList().Last<Modele.clients>().ADR_CLIENT = adr;
            modif_cli.ToList().Last<Modele.clients>().CP_CLIENT = cp;
            modif_cli.ToList().Last<Modele.clients>().VIL_CLIENT = v;
            modif_cli.ToList().Last<Modele.clients>().NAI_CLIENT = date;
            modif_cli.ToList().Last<Modele.clients>().TEL_CLIENT = tel;
            modif_cli.ToList().Last<Modele.clients>().EMAIL_CLIENT = email;
            modif_cli.ToList().Last<Modele.clients>().LOG_CLIENT = log;
            modif_cli.ToList().Last<Modele.clients>().MDP_CLIENT = mdp;
            db.SaveChanges();
        }
        // FIN MODIFIER

        public void Remove_Client(int n)
        {
            var sup_cat = from cat in db.clients
                          where cat.NUM_CLIENT == n
                          select cat;
            var l = db.clients.ToList();
            db.clients.Remove(sup_cat.ToList()[0]);
            db.SaveChanges();
        }
    }
}
