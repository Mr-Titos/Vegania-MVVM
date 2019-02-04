using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevellopementCursor
{
    class VueModeleClient
    {
        Modele.Donnees db = new Modele.Donnees();


        public void Newclient(int id)
        {
            db.clients.Add(new Modele.clients() { NUM_CLIENT = id });
            db.SaveChanges();
            var l = db.categories.ToList(); // le type var permet n'importe quel type primitif

            MessageBox.Show(l.LastOrDefault<Modele.categories>().LIB_CATEGORIE);
        }
        // DEBUT GET
        public String Get_IdAllClient()
        {
            //Selectionner toutes les catégories
            var cli = from cat in db.clients
                           select cat;
            string result = "";
            foreach (var p in cli.ToList())
            {
                result += p.NUM_CLIENT;
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
            return cli.ToList()[0].CP_CLIENT;
        }

        public string Get_NaiClient(int n)
        {
            var cli = from cat in db.clients
                      where cat.NUM_CLIENT == n
                      select cat;
            return Convert.ToString(cli.ToList()[0].NAI_CLIENT);
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

        public bool Get_PartClient(int n)
        {
            var cli = from cat in db.clients
                      where cat.NUM_CLIENT == n
                      select cat;
             
            return Convert.ToBoolean(cli.ToList()[0].Partenaire);
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

        // DEBUT MODIFIER
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

        public void Modify_PartClient(int n, bool m)
        {
            var modif_cli = from cat in db.clients
                            where cat.NUM_CLIENT == n
                            select cat;

            modif_cli.ToList().Last<Modele.clients>().Partenaire = m;
            db.SaveChanges();
        }

        public void Modify_Client(int n, String nom,String adr, String cp, String v, String nai, String tel, String email, bool pa, String log, String mdp)
        {
            // nai doit etre sous format YYYY-MM-DD
            var modif_cli = from cat in db.clients
                            where cat.NUM_CLIENT == n
                            select cat;
            DateTime date = Convert.ToDateTime(nai);
            modif_cli.ToList().Last<Modele.clients>().NOM_CLIENT = nom;
            modif_cli.ToList().Last<Modele.clients>().ADR_CLIENT = adr;
            modif_cli.ToList().Last<Modele.clients>().CP_CLIENT = cp;
            modif_cli.ToList().Last<Modele.clients>().VIL_CLIENT = v;
            modif_cli.ToList().Last<Modele.clients>().NAI_CLIENT = date;
            modif_cli.ToList().Last<Modele.clients>().TEL_CLIENT = tel;
            modif_cli.ToList().Last<Modele.clients>().EMAIL_CLIENT = email;
            modif_cli.ToList().Last<Modele.clients>().Partenaire = pa;
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
