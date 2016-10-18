namespace RepoQuiz.Migrations
{
    using DAL;
    using System.Data.Entity.Migrations;
    using Models;
    using System.Threading;

    internal sealed class Configuration : DbMigrationsConfiguration<RepoQuiz.DAL.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RepoQuiz.DAL.StudentContext context)
        {
            NameGenerator name_generator = new NameGenerator();
            for (var i = 0; i < 10; i++)
            {
                context.Students.AddOrUpdate(
                    s => s.LastName,
                    new Student
                    {
                        FirstName = name_generator.CreateFirstName(),
                        LastName = name_generator.CreateLastName(),
                        Major = name_generator.CreateMajor()
                    });
                // Since the Random class uses the computer's timestamp to generate a pseudo random
                // number, it will apply the same one if the timestamp is so close together for each 
                // iteration of this loop. Therefore, one solution is to slow down the loop like below.
                // The other solution (exploring), will be to move all the Random classes into one method,
                // because it is the .Next method that creates a fresh pseudo apparently, not the instantiation
                //of the Random class as I would have suspected. 
                Thread.Sleep(1000);
            }
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
