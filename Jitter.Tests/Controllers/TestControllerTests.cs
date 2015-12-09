using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jitter.Controllers;
using Microsoft.Web.Infrastructure;


namespace Jitter.Tests.Controllers
{
    [TestClass]
    public class TestControllerTests
    {
        [TestMethod]
        public void TestControllerEnsureICanCallGetAction()
        {
            TestController my_controller = new TestController();
            string expected_output = "Hello, it's me!";
            string actual_output = my_controller.Get();
        }
    }
}
