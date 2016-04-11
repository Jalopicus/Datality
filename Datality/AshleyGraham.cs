using System;
using Microsoft.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datality {
    using ComplexTypes;
    public class AshleyGraham : DbContext {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Filename=./OkGo.db");
        }
        public virtual DbSet<Pro> Pros { get; set; }
        public virtual DbSet<Raw> Raws { get; set; }
        public virtual DbSet<Blend> Blends { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Toxicity> Toxicities { get; set; }
        public virtual DbSet<SpecSet> SpecSets { get; set; }
        public virtual DbSet<Safety> Safeties { get; set; }
    }
    /// <summary>
    /// Tables/sets will inherit this base class
    /// </summary>
     public abstract class Bass {//: INotifyPropertyChanged {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        protected string Note { get; set; }
        /// <summary>
        /// The entity bass class implementation of INotifyPropertyChanged interface
        /// </summary>
        //public event PropertyChangedEventHandler PropertyChanged;
        //protected void OnPc(string propertyName) {
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
    public abstract class Chemical : Bass {
        public string Name { get; set; }
        public virtual Reggo Reg { get; set; }
        public virtual ICollection<Toxicity> Toxicities { get; set; }
    }
    /// <summary>
    /// Raw material
    /// </summary>
    public class Raw : Bass {
        public string Name { get; set; }
        public virtual Reggo Reg { get; set; }
        public virtual ICollection<Toxicity> Toxicities { get; set; } = new HashSet<Toxicity>();
        public string StockConcentration { get; set; }
        public string Cas { get; set; }
    }
    /// <summary>
    /// Combination of raw materials
    /// </summary>
    public class Blend : Chemical {
        public Blend() {
            Products = new HashSet<Pro>();
            Formulinos = new HashSet<Formulino>();
            Transport = new Transport();
        }
        public SpecSet SpecSet { get; set; }
        public virtual Safety Safety { get; set; }
        public virtual Transport Transport { get; set; }
        public virtual ICollection<Pro> Products { get; set; } = new HashSet<Pro>();
        public virtual ICollection<Formulino> Formulinos { get; set; } = new HashSet<Formulino>();
    }
    public class Formulino : Bass {
        public float Low { get; set; } = 0;
        public float High { get; set; } = 100;
        public float Actual { get; set; } = 0;
        public string Range { get; set; } = "0-100";
        public virtual Raw Raw { get; set; }
    }
    /// <summary>
    /// Aliasing and branding of a blend
    /// </summary>
    public class Pro : Bass {
        public Pro() {
            Blend = new Blend();
        }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Description { get; set; }
        //public DateTime IssueDate { get; set; }
        //public DateTime RevisionDate { get; set; }
        public int Version { get; set; }
        public virtual Blend Blend { get; set; }
        public virtual Brand Brand { get; set; }
    }
    public class SpecSet : Bass {
        //
    }
    public class Safety : Bass {
        //
    }
    public class BulletinText {
        //?
    }
    /// <summary>
    /// Toxicity entities
    /// </summary>
    public class Toxicity : Bass {
        public int Type { get; set; }
        public string Test { get; set; }
        public string Result { get; set; }
        public string Source { get; set; }
    }
    public class Brand : Bass {
        public string Name { get; set; }
        public string FullName { get; set; }
        public StreetAddress StreetAddress { get; set; }
        public string WebSite { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
    }
    /// <summary>
    /// Regulation lists 
    /// </summary>
    public class Reggo : Bass {
        public long Cercla { get; set; }
        public string Epa { get; set; }
        public bool Nsf { get; set; }
        public bool Kosher { get; set; }
        public bool Fda { get; set; }
        public Sara Sara { get; set; }
        public LegacyRatings LegacyRatings { get; set; }
    }
}