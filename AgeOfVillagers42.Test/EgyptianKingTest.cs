using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using AgeOfVillagers.Egyptian_Kings;

namespace AgeOfVillagers42.Test
{
    [TestClass]
    public class EgyptianKingTest
    {
        Point point = new Point(42, 42);

        [TestMethod]
        public void BackgroundColorTest()
        {
            EgyptianKings egyptianKingsBackgroundColor = new EgyptianKings();
            Color actual = egyptianKingsBackgroundColor.BackgroundColor();
            Color expected = Color.Yellow;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TreeTest()
        {
            EgyptianKings egyptianKingsTree = new EgyptianKings();
            Object actual = egyptianKingsTree.DrawTree(point);
            Object expected = new EgyptianKingsTrees(point);
            actual.Equals(expected);
        }

        [TestMethod]
        public void HouseTest()
        {
            EgyptianKings egyptianKingsHouse = new EgyptianKings();
            Object actual = egyptianKingsHouse.DrawHouse(point);
            Object expected = new EgyptianKingsTrees(point);
            actual.Equals(expected);
        }

        [TestMethod]
        public void WatersourceTest()
        {
            EgyptianKings egyptianKingsWaterSource = new EgyptianKings();
            Object actual = egyptianKingsWaterSource.DrawWaterSource(point);
            Object expected = new EgyptianKingsTrees(point);
            actual.Equals(expected);
        }
    }
}
