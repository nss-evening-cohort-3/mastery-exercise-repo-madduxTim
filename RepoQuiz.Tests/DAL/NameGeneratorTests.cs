using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.DAL;
using System.Collections.Generic;
using RepoQuiz.Models;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class NameGeneratorTests
    {
        //NameGenerator namegenerator = new NameGenerator();

        [TestMethod]
        public void AbleToInstantiate()
        {
            NameGenerator namegenerator = new NameGenerator();
            Assert.IsNotNull(namegenerator);
        }
        [TestMethod]
        public void CanGenerateFirstName()
        {
            NameGenerator namegenerator = new NameGenerator();
            var actual = namegenerator.CreateFirstName();
            string expected = "test string";
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(expected, actual.GetType());
        }
        [TestMethod]
        public void CanGenerateLastName()
        {
            NameGenerator namegenerator = new NameGenerator();
            var actual = namegenerator.CreateLastName();
            string expected = "test string";
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(expected, actual.GetType());
        }
        [TestMethod]
        public void CanGenerateMajor()
        {
            NameGenerator namegenerator = new NameGenerator();
            var actual = namegenerator.CreateMajor();
            string expected = "test string";
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(expected, actual.GetType());
        }
        [TestMethod]
        public void CanGenerateNewStudent()
        {
            NameGenerator namegenerator = new NameGenerator();
            Student actual = namegenerator.studentBuilder();
            Random test = new Random();
            int blah = test.Next(0, 100);
            int boogers = test.Next(0, 100);
            int jacket = test.Next(0, 100);
            int barf = test.Next(0, 20);
            Student expected = new Student() { FirstName="Ken", LastName="Bone", Major="Pre-Med" };
            Assert.IsInstanceOfType(expected, actual.GetType());
        }
    }
}
