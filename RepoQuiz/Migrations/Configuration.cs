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
            //Student student2 = name_generator.studentBuilder();
            //Student student3 = name_generator.studentBuilder();
            //Student student4 = name_generator.studentBuilder();
            //Student student5 = name_generator.studentBuilder();
            //Student student6 = name_generator.studentBuilder();
            //Student student7 = name_generator.studentBuilder();
            //Student student8 = name_generator.studentBuilder();
            //Student student9 = name_generator.studentBuilder();
            //Student student10 = name_generator.studentBuilder();

            context.Students.AddOrUpdate(s => s.LastName, student1);
            //context.Students.AddOrUpdate(
            //    s => s.LastName,
            //    new Student
            //    {
            //        FirstName = name_generator.CreateFirstName(),
            //        LastName = name_generator.CreateLastName(),
            //        Major = name_generator.CreateMajor()
            //    });

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
