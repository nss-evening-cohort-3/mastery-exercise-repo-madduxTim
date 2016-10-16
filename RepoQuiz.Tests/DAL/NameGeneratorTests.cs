using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.DAL;
using System.Collections.Generic;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class NameGeneratorTests
    {
        [TestMethod]
        public void AbleToInstantiate()
        {
            NameGenerator namegenerator = new NameGenerator();
            Assert.IsNotNull(namegenerator);
        }
        [TestMethod]
        public void CanGenerateStudent()
        {
            NameGenerator namegenerator = new NameGenerator();
            var actual = namegenerator.studentAssembly();
            //Dictionary<string, int> expected = new Dictionary<string, int>();
            List<string> expected = new List<string>();
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(expected, actual.GetType());
        }
    }
}
