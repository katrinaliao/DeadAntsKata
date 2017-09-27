using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeadAntsKata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeadAntsTest()
        {
            Assert.AreEqual(0, DeadAnts.Generate("ant ant ant ant"));
            Assert.AreEqual(0, DeadAnts.Generate(null));
            Assert.AreEqual(2, DeadAnts.Generate("ant anantt aantnt"));
            Assert.AreEqual(1, DeadAnts.Generate("ant ant .... a nt"));
        }

        public class DeadAnts
        {
            public static int Generate(string str)
            {
                if (str == null)
                {
                    return 0;
                }
                var genereted = str.Replace("ant", "");
                var factor = new string[] { "a", "n", "t" };
                return factor.Select(x => genereted.Count(y => y.ToString().Contains(x))).Max();
            }
        }
    }
}
