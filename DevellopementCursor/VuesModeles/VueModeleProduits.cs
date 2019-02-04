using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevellopementCursor
{
    class VueModeleProduits
    {
        Modele.Donnees db = new Modele.Donnees();


        public void Add_Prod(int nc, String lib, double pr, String Desc)
        {
            db.produits.Add(new Modele.produits() { NumCat = nc, LibProd = lib, PrixProd = Convert.ToSingle(pr), DescProd = Desc });
            db.SaveChanges();
            var l = db.produits.ToList(); // le type var permet n'importe quel type primitif
        }

        public String Get_AllLibProd()
        {
            var produits = from cat in db.produits
                           select cat;
            string result = "";
            foreach (var p in produits.ToList())
            {
                result += p.LibProd + ",";
            }
            return result;
        }

        public float Get_PrixProd(int n)
        {
            var produit = from cat in db.produits
                          where cat.IdProd == n
                          select cat;
            return produit.ToList()[0].PrixProd;
        }

        public String Get_DescProd(int n)
        {
            var produit = from cat in db.produits
                          where cat.IdProd == n
                          select cat;
            return produit.ToList()[0].DescProd;
        }

        public int Get_NumCatProd(int n)
        {
            var produit = from cat in db.produits
                          where cat.IdProd == n
                          select cat;
            return produit.ToList()[0].NumCat;
        }        public String Get_Prod(int n)
        {
            String r = "";
            var produit = from cat in db.produits
                          where cat.IdProd == n
                          select cat;
            return r = produit.ToList()[0].LibProd + "," + produit.ToList()[0].NumCat + ","+ produit.ToList()[0].PrixProd +","+ produit.ToList()[0].DescProd;
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

        public void Remove_Prod(int n)
        {
            var sup_cat = from cat in db.produits
                          where cat.IdProd == n
                          select cat;
            var l = db.produits.ToList();
            db.produits.Remove(sup_cat.ToList()[0]);
            db.SaveChanges();
        }
    }
}
