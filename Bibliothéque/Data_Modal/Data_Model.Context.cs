﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bibliothéque.Data_Modal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BibliothéqueEntities : DbContext
    {
        public BibliothéqueEntities()
            : base("name=BibliothéqueEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Emprinte> Emprintes { get; set; }
        public virtual DbSet<Filière> Filière { get; set; }
        public virtual DbSet<Groupe> Groupes { get; set; }
        public virtual DbSet<Ouvrage> Ouvrages { get; set; }
        public virtual DbSet<Secteur> Secteurs { get; set; }
        public virtual DbSet<Stagiaire> Stagiaires { get; set; }
        public virtual DbSet<Thème> Thème { get; set; }
        public virtual DbSet<Livre> Livres { get; set; }
        public virtual DbSet<Reserve> Reserves { get; set; }
    }
}
