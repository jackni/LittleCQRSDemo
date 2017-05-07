using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using SandBox.Helpers;

namespace SandBox.Test
{
    public class DummyTest
    {
        [Required]
        public string Id { get; set; }

        public string Description { get; set; }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testDummy = new DummyTest { Description = "test" };
            var validationResult = ValidationHelper.ValidateEntity<DummyTest>(testDummy);

            // Assert
            Assert.IsFalse(validationResult.HasError);
        }
    }
}
