﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoProvaFortes
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBProvaFortesEntities : DbContext
    {
        public DBProvaFortesEntities()
            : base("name=DBProvaFortesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbItem> tbItem { get; set; }
        public virtual DbSet<tbNota> tbNota { get; set; }
        public virtual DbSet<tbPrestador> tbPrestador { get; set; }
        public virtual DbSet<tbTomador> tbTomador { get; set; }
    }
}