using Demo10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo10.Models
{
    public class Dal:IDal

    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public void CreerRestaurant(string nom, string telephone)
        {
            bdd.Restos.Add(new Resto { Nom = nom, Telephone = telephone });
            bdd.SaveChanges();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public List<Resto> ObtienTousLesRestaurants()
        {
            return bdd.Restos.ToList();
        }

       
    }
}