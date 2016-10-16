using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.DAL;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class NameGeneratorTests
    {
        [TestMethod]
        public void CanInstantiate()
        {
            NameGenerator namegenerator = new NameGenerator();
            Assert.IsNotNull(namegenerator);
        }
    }
}
