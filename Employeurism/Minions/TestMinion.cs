using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datality;

namespace Employeurism.Minions {
    public class TestMinion {
        public Pro Pro { get; set; }
        public Blend Blend { get; set; }
        public Raw Raw { get; set; }
        public TestMinion() {
            using (var dt = new AshleyGraham()) {
                dt.Database.EnsureCreated();
                Pro= dt.Pros?.FirstOrDefault();
                Blend = Pro.Blend;
            }
        }
        public void MinionSave() {
            using (var dt = new AshleyGraham()) {
                dt.Pros.Update(Pro);
                dt.Blends.Update(Blend);
            }
        }
    }
}
