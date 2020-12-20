using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers;
using System.Drawing;

namespace AgeOfVillagers42.Test
{
    [TestClass]
    public class NullNationTest
    {
        Point point = new Point(42, 42);

        [TestMethod]
        public void BackgroundColorTest()
        {
            NullNation NullNationBackgroundColor = new NullNation();
            Color actual = NullNationBackgroundColor.BackgroundColor();
            Color expected = Color.White;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void NullItemTest()
        {
            NullNation nullItemTest = new NullNation();
            Object actual = nullItemTest.DrawTree(point);
            Object expected = new NullItems();
            actual.Equals(expected);
        }
    }
}
