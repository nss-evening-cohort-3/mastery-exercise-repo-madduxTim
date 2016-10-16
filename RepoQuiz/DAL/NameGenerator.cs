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
        public string[] FirstNames = new string[11] { "Barak", "GW", "Bill", "GHW", "Ronnie", "Jimmy", "Gerald", "Richard", "Lyndon", "John", "Dwight" };
        public string[] LastNames = new string[11] { "Obama", "Bush", "Clinton", "Bush", "Reagan", "Carter", "Ford", "Nixon", "Johnson", "Kennedy", "Eisenhower" };
        public string[] Majors = new string[8] { "Economics", "Literature", "Political Science", "Journalism", "Pre-Med", "Physics", "Sociology", "Biology" };


    }
}