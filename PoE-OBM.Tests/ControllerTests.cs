using Microsoft.AspNetCore.Mvc;
using PoE_OBM.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PoE_OBM.Tests
{
    public class ControllerTests
    {
        [Fact]
        public void VerifyIndexViewType()
        {
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }
    }
}
