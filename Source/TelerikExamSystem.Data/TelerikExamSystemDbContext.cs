﻿namespace TelerikExamSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;
    using TelerikExamSystem.Data.Contracts;
    using TelerikExamSystem.Data.Migrations;
    using TelerikExamSystem.Data.Models;

    public class TelerikExamSystemDbContext : IdentityDbContext<User>, ITelerikExamSystemDbContext
    {
        public TelerikExamSystemDbContext()
            : base("name=DefaultConnection(v11.0)", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TelerikExamSystemDbContext, DefaultMigrationConfiguration>());
        }

        public IDbSet<IdentityUserRole> UserRoles { get; set; }

        public static TelerikExamSystemDbContext Create()
        {
            return new TelerikExamSystemDbContext();
        }
 
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
