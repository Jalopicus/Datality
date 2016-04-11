using System.ComponentModel.DataAnnotations.Schema;
namespace Datality {
    namespace ComplexTypes {
        [ComplexType][NotMapped]
        public class Transport {
            public bool Hazardous { get; set; } = false;
            public string Un { get; set; }
            public string Psn { get; set; }
            public string ContainsField { get; set; }
            public string Primary { get; set; }
            public string Secondary { get; set; }
            public string PackingGroup { get; set; }
            /// <value>DOT, IMDG, etc</value>
            public string Type { get; set; } 
        }
        [ComplexType][NotMapped]
        public class Sara {
            public bool Acute { get; set; } = false;
            public bool Chronic { get; set; } = false;
            public bool Fire { get; set; } = false;
            public bool Pressure { get; set; } = false;
            public bool Reactivity { get; set; } = false;
            public Sara313 Sara313 { get; set; }
        }
        [ComplexType][NotMapped]
        public class LegacyRatings {
            public LegacyRating Hmis { get; set; } = new LegacyRating();
            public LegacyRating Nfpa { get; set; } = new LegacyRating();
            public LegacyRating Whims { get; set; } = new LegacyRating();
        }
        [ComplexType][NotMapped]
        public class LegacyRating {
            public int H { get; set; } = 0;
            public int F { get; set; } = 0;
            public int R { get; set; } = 0;
            public string Sp { get; set; } = null;
        }
        [ComplexType][NotMapped]
        public class StreetAddress {
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string Address3 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
        }
        [ComplexType][NotMapped]
        public class Sara313 {
            private bool Listed { get; set; } = false;
            public long Tpq { get; set; }
            public long Rq { get; set; }
        }
    }
}
