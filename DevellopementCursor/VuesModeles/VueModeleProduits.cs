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
            if (Desc.Length < 100 && lib.Length < 25)
            {
                db.produits.Add(new Modele.produits() { NumCat = nc, LibProd = lib, PrixProd = Convert.ToSingle(pr), DescProd = Desc });
                db.SaveChanges();
                var l = db.produits.ToList();  // le type var permet n'importe quel type primitif 
            }
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

        public String Get_AllIdProd()
        {
            var produits = from cat in db.produits
                           select cat;
            string result = "";
            foreach (var p in produits.ToList())
                result += p.IdProd + ",";

            return result;
        }

        public double Get_PrixProd(int n)
        {
            var produit = from cat in db.produits
                          where cat.IdProd == n
                          select cat;
            return produit.ToList()[0].PrixProd;
        }

        public String Get_LibProd(int n)
        {
            var produit = from cat in db.produits
                          where cat.IdProd == n
                          select cat;
            return produit.ToList()[0].LibProd;
        }

        public String Get_DescProd(int n)
        {
            var produit = from cat in db.produits
                          where cat.IdProd == n
                          select cat;
            return produit.ToList()[0].DescProd;
        }

        public String Get_NumCatProd(int n)
        {
            var produit = from cat in db.produits
                          where cat.IdProd == n
                          select cat;
            return  Convert.ToString(produit.ToList()[0].NumCat);
        }        public String Get_Prod(int n)
        {
            String r = "";
            var produit = from cat in db.produits
                          where cat.IdProd == n
                          select cat;
            return r = produit.ToList()[0].LibProd + "," + produit.ToList()[0].NumCat + "," + produit.ToList()[0].PrixProd + "," + produit.ToList()[0].DescProd;
        }        public void Modify_Prod(int n, int nuc, string lib, float p, string desc)
        {
            var modif_cat = from cat in db.produits
                            where cat.IdProd == n
                            select cat;

            modif_cat.ToList().Last<Modele.produits>().NumCat = nuc;
            modif_cat.ToList().Last<Modele.produits>().LibProd = lib;
            modif_cat.ToList().Last<Modele.produits>().PrixProd = p;
            modif_cat.ToList().Last<Modele.produits>().DescProd = desc;
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
