using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MailingListRegistry.Controllers;

namespace MailingListRegistry.Tests.Controllers
{
    [TestClass]
    public class RegisterControllerTest
    {
        [TestMethod]
        public void TestNew()
        {
            var controller = new RegisterController();
            Assert.IsNotNull(controller.New());
        }
    }
}
