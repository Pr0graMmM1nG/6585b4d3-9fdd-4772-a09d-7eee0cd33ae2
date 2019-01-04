using DataBaseLibrary.Models;
using SQLite.CodeFirst;
using System.Data.Entity;

namespace DataBaseLibrary.Context
{
    class PriceListContext:DbContext
    {
        public virtual DbSet<Furnizor> Furnizors { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Units> Unitss { get; set; }

        public PriceListContext()
        : base("default")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<PriceListContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

        }

    }
}
