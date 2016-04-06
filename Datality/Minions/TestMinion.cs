using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datality;

namespace Datality.Minions {
    public class TestMinion {
        public Product Product = new Product { };
        public Blend Blend = new Blend { };
        public Raw Raw = new Raw { };
        public TestMinion() {
         //   LoadPoopy();
            using (var dt = new DatalityContext()) {
                dt.Database.EnsureCreated();
                Product = dt.Products?.FirstOrDefault();
                Blend = Product?.Blend;
            }
        }
        public void MinionSave() {
            using (var dt = new DatalityContext()) {
                dt.Products.Update(Product);
                dt?.SaveChanges();
            }
        }
        public void MinionNext() {
            using (var dt = new DatalityContext()) {
                var index = dt.Products.ToList().FindIndex(i => i.Key == Product.Key);
                var Count = dt.Products.Count();
                Product = dt?.Products?.ToList().ElementAt((index + 1) % Count);
            }
        }
        private void LoadPoopy() {
            var R = new Raw { Name = "raw" };
            var RT = new Raw { Name = "raw2" };

            var P = new Product { Name = "praw" };
            var PT = new Product { Name = "praw2" };
            var B = new Blend { Name = "Blend" };
            var BT = new Blend { Name = "Blend2" };
            using (var dt = new DatalityContext()) {
                dt.Database.EnsureCreated();
                dt.Products.AddRange(P, PT);
                dt.Raws.AddRange(R, RT);
                dt.Blends.AddRange(B, BT);
                dt.SaveChanges();
            }
        }
    }
}
