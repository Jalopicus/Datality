using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datality;

namespace Employeurism.Minions {
    public class TestMinion {
        public Product Product { get; set; }
        public Blend Blend { get; set; }
        public Raw Raw { get; set; }
        public TestMinion() {
            using (var dt = new DatalityContext()) {
                dt.Database.EnsureCreated();
                Product = dt.Products?.FirstOrDefault();
                Blend = Product.Blend;
            }
        }
        public void MinionSave() {
            using (var dt = new DatalityContext()) {
                dt.Products.Update(Product);
                dt.Blends.Update(Blend);
            }
        }
    }
}
