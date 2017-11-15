namespace GitCherryManager.Migrations
{
    using GitCherryManager.Models.ContextModels.Git;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GitCherryManager.Entities.ManageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Entities.ManageContext context)
        {
            base.Seed(context);
            var codeShare = new CodeShare
            {
                CodeShareId = 1,
                Commits = new[]{
                                new Commit
                                {
                                    CommitId=1,
                                    Url="https://github.com/martea/SharedDemo/commit/6c0b0c485314c3632964cdfbba216c357c9ddc56"
                                }
                            }
            };
            var firstRepo = new Repository
            {
                RepositoryId = 1,
                Url = "https://github.com/martea/SharedDemo",
                CodeShares = new[]
                    {
                       codeShare
                    }
            };
            var secondRepo = new Repository
            {
                RepositoryId = 2,
                Url = "https://github.com/martea/SharedDemo",
            };
            context.Repositories.AddOrUpdate(firstRepo
              , secondRepo

        );

            context.CherryPicks.AddOrUpdate(new CherryPick
            {
                CherryPickId = 1,
                CodeShare = codeShare,
                Repository = secondRepo,
                MergeStatus = Models.Enumerables.MergeStatusType.Todo,
                ProccessStatus = Models.Enumerables.ProccessStatusType.Unproccessed

            });

            context.SaveChanges();



        }
    }
}
