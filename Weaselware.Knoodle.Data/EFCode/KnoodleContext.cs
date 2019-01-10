using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Weaselware.Knoodle.Data.Models;

namespace Weaselware.Knoodle.Data.EFCode
{
    public class KnoodleContext : DbContext
    {

        //private const string ConnectionString = @"Server=192.168.10.22;database=Badger;uid=sa;pwd=Kx09a32x;";

        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<Part> Part { get; set; }
        public virtual DbSet<Assembly> Assemblies { get; set; }
        public virtual DbSet<SubAssembly> SubAssemblies { get; set; }
        public virtual DbSet<ComponentPart> ComponentPart { get; set; }

        //This is working. and debugging is working!
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO place this string in the AppConfig--
            optionsBuilder.UseSqlServer(@"Server=192.168.10.3;DataBase=Badger;user id=sa; password=Kx09a32x");
        }
    
    



        protected override void
            OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AssemblyConfig());

        }
    }
}