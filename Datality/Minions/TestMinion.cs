using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datality;
using Datality.ComplexTypes;

namespace Datality.Minions {
    public class TestMinion {
        public Pro Pro = new Pro { };
        public Blend Blend = new Blend { };
        public Raw Raw = new Raw { };
        public TestMinion() {
         //   LoadPoopy();
            using (var dt = new AshleyGraham()) {
                dt.Database.EnsureCreated();
                Pro = dt.Pros?.FirstOrDefault();
                Blend = Pro?.Blend;
            }
        }
        public void MinionSave() {
            using (var dt = new AshleyGraham()) {
                dt.Pros.Update(Pro);
                dt?.SaveChanges();
            }
        }
        public void MinionNext() {
            using (var dt = new AshleyGraham()) {
                var index = dt.Pros.ToList().FindIndex(i => i.Id == Pro.Id);
                var Count = dt.Pros.Count();
                Pro = dt?.Pros?.ToList().ElementAt((index + 1) % Count);
            }
        }
        private void LoadPoopy() {
            var R = new Raw { Name = "raw" };
            var RT = new Raw { Name = "raw2" };

            var P = new Pro { Name = "praw" };
            var PT = new Pro { Name = "praw2" };
            var B = new Blend { Name = "Blend" };
            var BT = new Blend { Name = "Blend2" };
            using (var dt = new AshleyGraham()) {
                dt.Database.EnsureCreated();
                dt.Pros.AddRange(P, PT);
                dt.Raws.AddRange(R, RT);
                dt.Blends.AddRange(B, BT);
                dt.SaveChanges();
            }
        }
    }
}
