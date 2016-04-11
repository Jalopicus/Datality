using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using Fuckery.ClassRoom;

namespace Fuckery {
    public class DatalityContext : DbContext {
        public DbSet<Raw> Raws { get; set; }
        public DbSet<Blend> Blends { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Filename=./OkGo.db");
        }
    }
    /// <summary>
    /// Tables/sets will inherit this base class
    /// </summary>
    public abstract class Bass : INotifyPropertyChanged {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Key { get; set; }
        protected string Note { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPC(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    #region Chemical Entities
  
    /// <summary>
    /// Raw material
    /// </summary>
    public class Raw : Chemical {
        public string StockConcentration { get { return _stockConcentration; } set { _stockConcentration = value; OnPC("StockConcentration"); } }
        private string _stockConcentration = null;
        public string Cas { get { return _cas; } set { _cas = value; OnPC("Cas"); } }
        private string _cas = null;
    }
    /// <summary>
    /// Solution of raws
    /// </summary>
    public class Blend : Chemical {
        protected ICollection<Formulino> Formulinos;
        protected SpecSet SpecSet;
        protected SafetyData SafetyData;
        //Transport
    }
    /// <summary>
    /// Branding on blend of raws
    /// </summary>
    public class Product : Bass {
        public string Name { get { return _name; } set { _name = value; OnPC("Name"); } }
        private string _name;
        public string Class { get { return _class; } set { _class = value; OnPC("Class"); } }
        private string _class;
        public string Description { get { return _description; } set { _description = value; OnPC("Description"); } }
        private string _description;

        public DateTime IssueDate;
        public DateTime RevisionDate;
        public int Version;
        public Blend Blend;
        public Brand Brand;
    }
    #endregion
    #region Documentation
    public class SpecSet : Bass {
        //
    }
    public class SafetyData : Bass {
        //
    }
    public class BulletinText {
        //?
    }
    /// <summary>
    /// Toxicity entities
    /// </summary>
    public abstract class Toxicity : Bass {
        public string Test { get { return _test; } set { _test = value; OnPC("Test"); } }
        private string _test;
        public string Result { get { return _result; } set { _result = value; OnPC("Result"); } }
        private string _result;
        public string Source { get { return _source; } set { _source = value; OnPC("Source"); } }
        private string _source;
    }
    #endregion

    #region Branding
    public class Brand : Bass {
        public string Name { get; set; }
        public string FullName { get; set; }
        //public StreetAddress StreetAddress { get; set; }
        //public UrlAttribute WebSite { get; set; }
        //public PhoneAttribute Phone { get; set; }
        //public EmailAddressAttribute Email { get; set; }
        public string Contact { get; set; }
    }
    
    #endregion

    #region Regulatory
    /// <summary>
    /// Regulation lists 
    /// </summary>
    public class Reggo : Bass {
        public long Cercla { get { return _cercla; } set { _cercla = value; OnPC("Cercla"); } }
        private long _cercla;

        public string Epa { get { return _epa; } set { _epa = value; OnPC("Epa"); } }
        private string _epa;
        public bool Nsf { get { return _nsf; } set { _nsf = value; OnPC("Nsf"); } }
        private bool _nsf = false;
        public bool Kosher { get { return _kosher; } set { _kosher = value; OnPC("Kosher"); } }
        private bool _kosher = false;
        public bool Fda { get { return _fda; } set { _fda = value; OnPC("Fda"); } }
        private bool _fda = false;
        //public Sara Sara { get; set; }
        public LegacyRatings LegacyRatings { get; set; }
    }
  public class Transport : Bass {
        public string Un;
        public string Psn;
        public string ContainsField;
        public string Primary;
        public string Secondary;
        public string PackingGroup;
        public string Type; //(air, dot, etc)
    }


    public class LegacyRatings {
        HMIS Hmis;
        NFPA Nfpa;
        WHIMS Whims;
    }
    #endregion
}
