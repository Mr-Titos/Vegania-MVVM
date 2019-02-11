using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevellopementCursor
{
    class VueModeleCategorie
    {
        Modele.Donnees db = new Modele.Donnees();


        public void Add_Categorie( String lib)
        {
            if (lib.Length < 100)
            {
                db.categories.Add(new Modele.categories() { LIB_CATEGORIE = lib });
                db.SaveChanges();
                var l = db.categories.ToList(); // le type var permet n'importe quel type primitif
            }
        }

        public int Get_IdCategorie(String n)
        {
            var produit = from cat in db.categories
                          where cat.LIB_CATEGORIE == n
                          select cat;
            return produit.ToList()[0].NUM_CATEGORIE ;
        }

        public String Get_AllIdCategorie()
        {
            var produits = from cat in db.categories
                           select cat;
            string result = "";
            foreach (var p in produits.ToList())
            {
                result += p.NUM_CATEGORIE + ",";
            }
            return result;
        }        public String Get_LibCategorie(int n)
        {
            var produit = from cat in db.categories
                          where cat.NUM_CATEGORIE == n
                          select cat;
            return produit.ToList()[0].LIB_CATEGORIE;
        }
        public String Get_AllCategorie()
        {
            var produits = from cat in db.categories
                           select cat;
            string result = "";
            foreach (var p in produits.ToList())
            {
                result += p.LIB_CATEGORIE + ",";
            }
            return result;
        }

        public String Get_NextIdCat()
        {
            var produits = from cat in db.categories
                           select cat;
            int result = 0;
            foreach (var p in produits.ToList())
                result = Convert.ToInt32(p.NUM_CATEGORIE);
            String temp = result.ToString();
            result = 1 + Convert.ToInt32(temp);
            return temp;
        }

        public int Get_NbCat()
        {
            var produits = from cat in db.categories
                           select cat;
            int result = 0;
            foreach (var p in produits.ToList())
            {
                result += 1;
            }
            return result;
        }

        public void Modify_Categorie(int n, string m)
        {
            var modif_cat = from cat in db.categories
                            where cat.NUM_CATEGORIE == n
                            select cat;

            modif_cat.ToList().Last<Modele.categories>().LIB_CATEGORIE = m;
            db.SaveChanges();
        }

        public void Remove_Categorie(int n)
        {
            var sup_cat = from cat in db.categories
                          where cat.NUM_CATEGORIE == n
                          select cat;
            var l = db.categories.ToList();
            db.categories.Remove(sup_cat.ToList()[0]);
            db.SaveChanges();
        }
    }
}
