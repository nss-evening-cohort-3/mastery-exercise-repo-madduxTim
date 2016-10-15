using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RepoQuiz.DAL;
using System.Data.Entity;
using RepoQuiz.Models;
using System.Collections.Generic;
using System.Linq;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class StudentRepositoryTests
    {
        //Set up Moq / mock context 
        Mock<StudentContext> mock_context { get; set; }
        List<Student> student_list { get; set; }
        Mock<DbSet<Student>> mock_student_table { get; set; }
        StudentRepo repo { get; set; }

        //bogus students
        Student fauxStudent1 = new Student { StudentID = 1, FirstName = "Tobey", LastName = "Shmobey", Major = "Economics" };
        Student fauxStudent2 = new Student { StudentID = 2, FirstName = "Jimmy", LastName = "Shmimmy", Major = "English" };
        Student fauxStudent3 = new Student { StudentID = 3, FirstName = "Sarah", LastName = "Shmarah", Major = "Engineering" };

        //Add LINQ-queryability to student lists
        public void ConnectMocksToDatastore()
        {
            var queryable_student_list = student_list.AsQueryable();
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.Provider).Returns(queryable_student_list.Provider);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.Expression).Returns(queryable_student_list.Expression);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.ElementType).Returns(queryable_student_list.ElementType);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.GetEnumerator()).Returns(queryable_student_list.GetEnumerator);
            mock_context.Setup(s => s.Students).Returns(mock_student_table.Object);
            mock_student_table.Setup(s => s.Add(It.IsAny<Student>())).Callback((Student s) => student_list.Add(s));
            mock_student_table.Setup(s => s.Remove(It.IsAny<Student>())).Callback((Student s) => student_list.Remove(s));
        }

        [TestInitialize]
        public void Initialize()
        {
            mock_context = new Mock<StudentContext>();
            mock_student_table = new Mock<DbSet<Student>>();
            student_list = new List<Student>();
            repo = new StudentRepo(mock_context.Object);
            ConnectMocksToDatastore();
        }

        [TestCleanup]
        public void TearDown()
        {
            repo = null;
        }

        [TestMethod]
        public void CanCreateModelClassInstance()
        {
            StudentRepo repo = new StudentRepo();
            Assert.IsNotNull(repo);
        }

        [TestMethod]
        public void CanCreateInstanceWithMockInitialized()
        {
            Assert.IsNotNull(repo);
        }

        [TestMethod]
        public void RepoHasContext()
        {
            StudentContext actual = repo.Context;
            Assert.IsInstanceOfType(actual, typeof(StudentContext));
        }

        [TestMethod]
        public void StudentDbIsEmpty()
        {
            List<Student> all_students = repo.GetAllStudents();
            int expected = 0;
            int actual = all_students.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void canAddStudentToDatabase()
        {
            repo.AddNewStudent(fauxStudent1);
            List<Student> all_students = repo.GetAllStudents();
            int expected = 1;
            int actual = all_students.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindStudentById()
        {
            repo.AddNewStudent(fauxStudent1);
            repo.AddNewStudent(fauxStudent2);
            repo.AddNewStudent(fauxStudent3);
            int student_id = 3;
            int expected_student_id = 3;
            Student actual_student = repo.FindStudent(student_id);
            int actual_student_id = actual_student.StudentID;
            Assert.AreEqual(expected_student_id, actual_student_id);
        }

        [TestMethod]
        public void FindStudentByFirstNameOrLastName()
        {
            repo.AddNewStudent(fauxStudent2);
            string student_name = "Jimmy";
            Student expected_student = fauxStudent2;
            Student actual_student = repo.FindStudent(student_name);
            Assert.AreEqual(expected_student, actual_student);
        }

        [TestMethod]
        public void RemoveStudentById()
        {
            List<Student> fauxMiniRepo = new List<Student>() { fauxStudent1, fauxStudent2, fauxStudent3 };
            repo.AddNewStudent(fauxStudent1);
            repo.AddNewStudent(fauxStudent2);
            repo.AddNewStudent(fauxStudent3);
            Assert.AreEqual(fauxMiniRepo.Count, repo.GetAllStudents().Count);
            repo.DeleteStudent(fauxStudent1.StudentID); //my method 
            fauxMiniRepo.Remove(fauxStudent1); // test against generic collection method 
            Assert.AreEqual(fauxMiniRepo.Count, repo.GetAllStudents().Count);
        }

        [TestMethod]
        public void RemoveStudentByFirstOrLastName()
        {
            List<Student> fauxMiniRepo = new List<Student>() { fauxStudent1, fauxStudent2, fauxStudent3 };
            repo.AddNewStudent(fauxStudent1);
            repo.AddNewStudent(fauxStudent2);
            repo.AddNewStudent(fauxStudent3);
            Assert.AreEqual(fauxMiniRepo.Count, repo.GetAllStudents().Count);
            string studentName = "Jimmy";
            repo.DeleteStudent(studentName); //my method 
            fauxMiniRepo.Remove(fauxStudent1); // test against generic collection method 
            Assert.AreEqual(fauxMiniRepo.Count, repo.GetAllStudents().Count);
        }
    }
}
