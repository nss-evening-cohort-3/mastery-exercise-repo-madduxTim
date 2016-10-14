using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RepoQuiz.Models;

namespace RepoQuiz.DAL
{
    public class StudentRepo
    {
        public StudentContext Context { get; set; }
        public StudentRepo()
        {
            Context = new StudentContext();
        }
        public StudentRepo(StudentContext _context)
        {
            Context = _context;
        }

        public List<Student> GetAllStudents()
        {
            return Context.Students.ToList();
        }
    }
}