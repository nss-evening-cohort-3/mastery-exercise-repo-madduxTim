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

        public void AddNewStudent(Student student)
        {
            Context.Students.Add(student);
            Context.SaveChanges();
        }

        public Student FindStudent(int student_id)
        {
            Student student = Context.Students.FirstOrDefault(s => s.StudentID == student_id);
            return student;
        }

        public Student FindStudent(string student_name)
        {
            Student student = Context.Students.FirstOrDefault(s => s.FirstName == student_name || s.LastName == student_name);
            return student;
        }

        public void DeleteStudent(int studentID)
        {
            Student student = Context.Students.FirstOrDefault(s => s.StudentID == studentID);
            Context.Students.Remove(student);
        }

        public void DeleteStudent(string name)
        {
            Student student = Context.Students.FirstOrDefault(s => s.FirstName == name || s.LastName == name);
            Context.Students.Remove(student);
        }
    }
}