using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers;
using AgeOfVillagers.Bangladeshi_Farmers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace AgeOfVillagers42.Test
{
    [TestClass]
    public class BangladeshiFarmersTest
    {
        Point point = new Point(42, 42);

        [TestMethod]
        public void BackgroundColorTest()
        {
            BangladeshiFarmers bdFarmersBackgroundColor = new BangladeshiFarmers();
            Color actual = bdFarmersBackgroundColor.BackgroundColor();
            Color expected = Color.Green;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TreeTest()
        {
            BangladeshiFarmers bdFarmersTree = new BangladeshiFarmers();
            Object actual = bdFarmersTree.DrawTree(point);
            Object expected = new BDFarmersTree(point);
            actual.Equals(expected);
        }

        [TestMethod]
        public void HouseTest()
        {
            BangladeshiFarmers bdFarmersHouse = new BangladeshiFarmers();
            Object actual = bdFarmersHouse.DrawHouse(point);
            Object expected = new BDFarmersHouse(point);
            actual.Equals(expected);
        }

        [TestMethod]
        public void WatersourceTest()
        {
            BangladeshiFarmers bdFarmersWS = new BangladeshiFarmers();
            Object actual = bdFarmersWS.DrawWaterSource(point);
            Object expected = new BDFarmersWatersource(point);
            actual.Equals(expected);
        }
    }
}
