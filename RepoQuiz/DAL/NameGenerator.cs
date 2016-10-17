using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RepoQuiz.Models;

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

        public Student studentBuilder()
        {
            Student student = new Student();
            Random random = new Random();
            int rand1 = random.Next(0, FirstNames.Length - 1);
            int rand2 = random.Next(0, LastNames.Length - 1);
            int rand3 = random.Next(0, Majors.Length - 1);
            student.FirstName = FirstNames[rand1];
            student.LastName = LastNames[rand2];
            student.Major = Majors[rand3];
            //student.FirstName = CreateFirstName();
            //student.LastName = CreateLastName();
            //student.Major = CreateMajor();
            return student;
        } 

            //THIS APPROACH WAS NOT WORKING FOR SOME REASON... 
        public string CreateFirstName()
        {
            Random randomFirst = new Random();
            int FirstNameNum = randomFirst.Next(0, FirstNames.Length - 1);
            string FirstName = FirstNames[FirstNameNum];
            return FirstName;
        }
        public string CreateLastName()
        {
            Random randomLast = new Random();
            int LastNameNum = randomLast.Next(0, LastNames.Length - 1);
            string LastName = LastNames[LastNameNum];
            return LastName;
        }
        public string CreateMajor()
        {
            Random randomMajor = new Random();
            int MajorNumber = randomMajor.Next(0, Majors.Length - 1);
            string Major = Majors[MajorNumber];
            return Major;
        }
    }
}