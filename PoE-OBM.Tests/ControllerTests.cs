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

        [Fact]
        public void VerifyBuildSave()
        {
            var controller = new BuildController();
            var actionResult = controller.CreateBuild(new Models.ExileBuild 
            {
                Name = "Test",
                userId = 1,
                ExileClass = Models.BuildClass.Witch
            });

            Assert.NotNull(actionResult);
        }
    }
}
