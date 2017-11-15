using GitCherryManager.Models.ContextModels.Git;
using System.Data.Entity;

namespace GitCherryManager.Entities
{
    public class ManageContext : DbContext
    {
        public ManageContext() : base("Manage")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ManageContext>());

        }
        public DbSet<Repository> Repositories { get; set; }
        public DbSet<CodeShare> CodeShares { get; set; }
        public DbSet<Commit> Commits { get; set; }
        public DbSet<CherryPick> CherryPicks { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
