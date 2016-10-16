using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.DAL;
using System.Collections.Generic;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class NameGeneratorTests
    {
        NameGenerator namegenerator = new NameGenerator();

        [TestMethod]
        public void AbleToInstantiate()
        {
            Assert.IsNotNull(namegenerator);
        }
        [TestMethod]
        public void CanGenerateStudent()
        {
            var actual = namegenerator.studentAssembly();
            //Dictionary<string, int> expected = new Dictionary<string, int>();
            List<string> expected = new List<string>();
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(expected, actual.GetType());
        }
        [TestMethod]
        public void CanGenerateFirstName()
        {
            var actual = namegenerator.CreateFirstName();
            string expected = "test string";
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(expected, actual.GetType());
        }
        [TestMethod]
        public void CanGenerateLastName()
        {
            var actual = namegenerator.CreateLastName();
            string expected = "test string";
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(expected, actual.GetType());
        }
        [TestMethod]
        public void CanGenerateMajor()
        {
            var actual = namegenerator.CreateMajor();
            string expected = "test string";
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(expected, actual.GetType());
        }
    }
}
