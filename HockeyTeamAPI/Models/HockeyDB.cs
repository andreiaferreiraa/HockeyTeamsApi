using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace HockeyTeamAPI.Models
{
    public class HockeyDB : DbContext
    {

        public HockeyDB() : base("HoqueiDBConnectionString")
        { }




        public virtual DbSet<Jogadores> Jogadores { get; set; }
        public virtual DbSet<Equipas> Equipas { get; set; }
        public virtual DbSet<Multimedia> Multimedia { get; set; }

        /// <summary>
        /// configura a forma como as tabelas são criadas
        /// </summary>
        /// <param name="modelBuilder"> objeto que referencia o gerador de base de dados </param>      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }



    }
}