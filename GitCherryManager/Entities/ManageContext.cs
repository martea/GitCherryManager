using GitCherryManager.Models.ContextModels.Git;
using System.Data.Entity;

namespace GitCherryManager.Entities
{
    public class ManageContext : DbContext
    {
        public ManageContext() : base("ManageContext")
        {

        }
        public DbSet<CherryPick> CherryPicks { get; set; }
        public DbSet<Commit> Commits { get; set; }
        public DbSet<Repository> Repositories { get; set; }
    }
    public class ManageContextInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ManageContext>
    {
    }
}
