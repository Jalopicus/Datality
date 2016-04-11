using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Linq;
using Datality;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() {
            var R = new Raw { Name = "raw" };
            var RT = new Raw { Name = "raw2" };

            var P = new Pro { Name = "praw" };
            var PT = new Pro { Name = "praw2" };
            var B = new Blend { Name = "Blend" };
            var BT = new Blend { Name = "Blend2" };
            using (var dt = new AshleyGraham()) {
                dt.Database.EnsureCreated();
                dt.Pros.AddRange( P,PT);
                dt.Raws.AddRange(R, RT);
                dt.Blends.AddRange(B, BT);
                dt.SaveChanges();
            }

            using (var dt = new AshleyGraham()) {

                var a = dt.Model.ToString();
                    }
        }
    }
}
