using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers.Arab_Bedouin;
using AgeOfVillagers;
using System.Drawing;

namespace AgeOfVillagers42.Test
{
    [TestClass]
    public class ArabBedouinTest
    {
        Point point = new Point(42, 42);

        [TestMethod]
        public void BackgroundColorTest()
        {
            ArabBedouin arabBedouinBackgroundColor = new ArabBedouin();
            Color actual = arabBedouinBackgroundColor.BackgroundColor();
            Color expected = Color.GreenYellow;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TreeTest()
        {
            ArabBedouin arabBedouinTree = new ArabBedouin();
            Object actual = arabBedouinTree.DrawHouse(point);
            Object expected = new ArabBedouinTrees(point);
            actual.Equals(expected);
        }

        [TestMethod]
        public void HouseTest()
        {
            ArabBedouin arabBedouinHouse = new ArabBedouin();
            Object actual = arabBedouinHouse.DrawHouse(point);
            Object expected = new ArabBedouinHouse(point);
            actual.Equals(expected);
        }

        [TestMethod]
        public void WaterSourceTest()
        {
            ArabBedouin arabBedouinWaterSource = new ArabBedouin();
            Object actual = arabBedouinWaterSource.DrawWaterSource(point);
            Object expected = new NullItems();
            actual.Equals(expected);
        }
    }
}
