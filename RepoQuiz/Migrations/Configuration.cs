namespace RepoQuiz.Migrations
{
    using DAL;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RepoQuiz.DAL;

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
                new Models.Student() { FirstName = name_generator.CreateFirstName(), LastName = name_generator.CreateLastName(), Major = name_generator.CreateMajor() });
            }

            // HOW TO MAKE USE OF THIS WITH SEED METHOD... 
            //List<string> student1 = name_generator.studentAssembly();
            //List<string> student2 = name_generator.studentAssembly();
            //List<string> student3 = name_generator.studentAssembly();
            //List<string> student4 = name_generator.studentAssembly();
            //List<string> student5 = name_generator.studentAssembly();
            //List<string> student6 = name_generator.studentAssembly();
            //List<string> student7 = name_generator.studentAssembly();
            //List<string> student8 = name_generator.studentAssembly();
            //List<string> student9 = name_generator.studentAssembly();
            //List<string> student10 = name_generator.studentAssembly();

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
