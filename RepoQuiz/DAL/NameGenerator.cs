using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepoQuiz.DAL
{
    public class NameGenerator
    {
        // This class should be used to generate random names and Majors for Students.
        // This is NOT your Repository
        // All methods should be Unit Tested :)
        public string[] FirstNames = new string[19] { "Barak", "GW", "Bill", "GHW", "Ronnie", "Jimmy", "Gerald", "Richard", "Lyndon", "John", "Dwight", "Harry", "Franklin", "Herbert", "Calvin", "Warren G", "Woodrow", "William", "Teddy" };
        public string[] LastNames = new string[17] { "Obama", "Bush", "Clinton", "Reagan", "Carter", "Ford", "Nixon", "Johnson", "Kennedy", "Eisenhower", "Truman", "Roosevelt", "Herbert", "Coolidge", "Harding", "Wilson", "Taft" };
        public string[] Majors = new string[8] { "Economics", "Literature", "Political Science", "Journalism", "Pre-Med", "Physics", "Sociology", "Biology" };

        List<string> student = new List<string>();

        public List<string> studentAssembly()
        {
            Random rando = new Random();
            int FirstNameNum = rando.Next(0, FirstNames.Count() - 1);
            int LastNameNum = rando.Next(0, LastNames.Count() - 1);
            int MajorNumber = rando.Next(0, Majors.Count() - 1);
            student.Add(FirstNames[FirstNameNum]);
            student.Add(LastNames[LastNameNum]);
            student.Add(Majors[MajorNumber]);
            return student;
        }

        public string CreateFirstName()
        {
            Random rando = new Random();
            int FirstNameNum = rando.Next(0, FirstNames.Count() - 1);
            string FirstName = FirstNames[FirstNameNum];
            return FirstName;
        }
        public string CreateLastName()
        {
            Random rando = new Random();
            int MajorNumber = rando.Next(0, Majors.Count() - 1);
            string Major = Majors[MajorNumber];
            return Major;
        }
        public string CreateMajor()
        {
            Random rando = new Random();
            int LastNameNum = rando.Next(0, LastNames.Count() - 1);
            string LastName = LastNames[LastNameNum];
            return LastName;
        }
    }
}