using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevellopementCursor
{
    class VueModelePartenaire
    {
        Modele.Donnees db = new Modele.Donnees();


        //DEBUT GET

      public String Get_AllIdPart()
        {
            var part = from cat in db.partenaire
                      select cat;
            string result = "";
            foreach (var p in part.ToList())
                result += p.NUM_CLI + ",";

            return result;
        }

        public string Get_Niveau(int n)
        {
            var cli = from cat in db.partenaire
                      where cat.NUM_CLI == n
                      select cat;
            return cli.ToList()[0].NIVEAU;
        }

        public int Get_PourcReduc(int n)
        {
            var cli = from cat in db.partenaire
                      where cat.NUM_CLI == n
                      select cat;
            return cli.ToList()[0].POURC_REDUC;
        }
        //FIN GET

        //DEBUT SET

        public void Set_Niveau(int n, String m)
        {
            var modif = from cat in db.partenaire
                            where cat.NUM_CLI == n
                            select cat;

            modif.ToList().Last<Modele.partenaire>().NIVEAU = m;
            db.SaveChanges();
        }

        public void Set_PourcReduc(int n, int m)
        {
            var modif = from cat in db.partenaire
                        where cat.NUM_CLI == n
                        select cat;

            modif.ToList().Last<Modele.partenaire>().POURC_REDUC = m;
            db.SaveChanges();
        }
        //FIN SET

        public void Remove_Part(int n)
        {
            var sup_cat = from cat in db.partenaire
                          where cat.NUM_CLI == n
                          select cat;
            var l = db.partenaire.ToList();
            db.partenaire.Remove(sup_cat.ToList()[0]);
            db.SaveChanges();
        }

        public void Add_Partenaire(int n, String niv, int pc)
        {
            if (niv.Length < 51 && pc < 100)
            {
                db.partenaire.Add(new Modele.partenaire() {NUM_CLI = n, NIVEAU = niv, POURC_REDUC = pc });
                db.SaveChanges();
                var l = db.categories.ToList(); 
            }
        }
    }
}
