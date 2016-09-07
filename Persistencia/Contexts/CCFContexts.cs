using CCFoodsServer2.Migrations;
using CCFoodsServer2.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CCFoodsServer2.Persistencia.Contexts
{
    public class CCFContexts : DbContext
    {
//        public CCFContexts() : base("CCFoods_CS") {
        public CCFContexts()
        {
            Database.SetInitializer<CCFContexts>(new MigrateDatabaseToLatestVersion<CCFContexts, Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Garcom> Garcons { get; set; }
    }
}
