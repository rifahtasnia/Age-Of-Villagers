using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers.Inuit_Hunters;
using AgeOfVillagers;
using System.Drawing;

namespace AgeOfVillagers42.Test
{
    [TestClass]
    public class InuitHuntersTest
    {
        Point point = new Point(42, 42);

        [TestMethod]
        public void BackgroundColorTest()
        {
            InuitHunters inuitHuntersBackgroundColor = new InuitHunters();
            Color actual = inuitHuntersBackgroundColor.BackgroundColor();
            Color expected = Color.White;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TreeTest()
        {
            InuitHunters inuitHuntersTree = new InuitHunters();
            Object actual = inuitHuntersTree.DrawTree(point);
            Object expected = new NullItems();
            actual.Equals(expected);
        }

        [TestMethod]
        public void HouseTest()
        {
            InuitHunters inuitHuntersHouse = new InuitHunters();
            Object actual = inuitHuntersHouse.DrawHouse(point);
            Object expected = new InuitHuntersHouse(point);
            actual.Equals(expected);
        }

        [TestMethod]
        public void WaterSourceTest()
        {
            InuitHunters inuitHuntersWatersource = new InuitHunters();
            Object actual = inuitHuntersWatersource.DrawWaterSource(point);
            Object expected = new NullItems();
            actual.Equals(expected);
        }
    }
}
