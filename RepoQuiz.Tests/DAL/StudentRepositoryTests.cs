using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RepoQuiz.DAL;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class StudentRepositoryTests
    {
        //Set up Moq / mock context 
        Mock<StudentContext> mock_context { get; set; }


        [TestInitialize]
        //mock_context = new Mock<StudentContext>();
    }
}
