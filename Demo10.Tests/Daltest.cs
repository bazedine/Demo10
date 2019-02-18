using System;
using System.Collections.Generic;
using Demo10.Models;
using Demo10.repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Demo10.Models;

namespace Demo10.Tests
{
    [TestClass]
    public class Daltest
    {

        [TestMethod]
        public void CreerRestaurant()
        {

            using (IDal dal = new Dal())
            {
                dal.CreerRestaurant("La bonne fourchette", "01 02 03 04 05");
                List<Resto> restos = dal.ObtienTousLesRestaurants();

                Assert.IsNotNull(restos);
                //Assert.AreEqual(1, restos.Count);
                Assert.AreEqual("La bonne fourchette", restos[0].Nom);
                Assert.AreEqual("01 02 03 04 05", restos[0].Telephone);
            }
        }
    }
}
