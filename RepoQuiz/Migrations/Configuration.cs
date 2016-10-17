namespace RepoQuiz.Migrations
{
    using DAL;
    using System.Data.Entity.Migrations;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<RepoQuiz.DAL.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RepoQuiz.DAL.StudentContext context)
        {
            NameGenerator name_generator = new NameGenerator();
            Student student1 = name_generator.studentBuilder();
            //List<string> student2 = name_generator.studentAssembly();
            //List<string> student3 = name_generator.studentAssembly();
            //List<string> student4 = name_generator.studentAssembly();
            //List<string> student5 = name_generator.studentAssembly();

            context.Students.AddOrUpdate(s => s.LastName, student1);
                //s => s.LastName,
                //new Models.Student()
                //{
                //    FirstName = name_generator.CreateFirstName(),
                //    LastName = name_generator.CreateLastName(),
                //    Major = name_generator.CreateMajor()
                //});

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
