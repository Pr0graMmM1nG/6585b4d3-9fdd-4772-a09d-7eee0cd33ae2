using SQLite.CodeFirst;
using System.Data.Entity;

namespace DataBaseLibrary.Context
{
    class PriceListContext:DbContext
    {
        //public virtual DbSet<User> Users { get; set; }

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
