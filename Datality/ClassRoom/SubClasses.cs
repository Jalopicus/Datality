using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuckery.ClassRoom {
    /// <summary>
    /// Chemical base
    /// </summary>
    public abstract class Chemical : Bass {
        public string Name { get { return _name; } set { _name = value; OnPC("Name"); } }
        private string _name;
        public Reggo Reg { get; set; }
        public ICollection<Toxicity> Toxicities = new HashSet<Toxicity> { };
    }
    public class Formulino : Bass {
        public Single Low;
        public Single High;
        public Single Actual;
        public Raw Raw;
    }
    public class StreetAddress {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
    public class Sara313 {
        public long Tpq { get; set; }
        public long Rq { get; set; }
    }
    /// <summary>
    /// Legacy rating systems of 0-4
    /// </summary>
    //public abstract class LegacyRating {
    //    public LegacyRating() { }
    //    int H { get { return _h; } set { _h = value; } }
    //    int _h = 0;
    //    int F { get { return _f; } set { _f = value; } }
    //    int _f = 0;
    //    int R { get { return _r; } set { _r = value; } }
    //    int _r = 0;
    //    string S { get { return _s; } set { _s = value; } }
    //    string _s = null;
    //}
    //public class HMIS : LegacyRating { }
    //public class WHIMS : LegacyRating { }
    //public class NFPA : LegacyRating { }
    struct HMIS { 
        int H; int F; int R; string Sp;
    }
    struct NFPA {
        int H; int F; int R; string Sp;
    }
    struct WHIMS {
        int H; int F; int R; string Sp;
    }

    public struct Butt {
        string Butthole;
        string Buttcheek;
        string Pants;
    }
}
