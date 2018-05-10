using Microsoft.AspNetCore.Mvc;
using Moq;
using PoE_OBM.Controllers;
using PoE_OBM.Services;
using Xunit;

namespace PoE_OBM.Tests
{
    public class BuildControllerTests
    {
        [Fact]
        public void CreateBuild_ReturnsARedirectToIndexWhenBuildIsSaved()
        {
            var mockBuildData = new Mock<IBuildData>();
            var controller = new BuildController(mockBuildData.Object);
            var actionResult = controller.CreateBuild(new Models.ExileBuild 
            {
                Name = "Test",
                userId = 1,
                ExileClass = Models.BuildClass.Witch
            });

            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(actionResult);
            Assert.Equal("Index", redirectToActionResult.ActionName);
        }

        [Fact]
        public void CreateBuild_ReturnsARedirectToCreateNewBuildViewWhenBuildSaveFails()
        {
            var mockBuildData = new Mock<IBuildData>();
            var controller = new BuildController(mockBuildData.Object);
            controller.ModelState.AddModelError("error", "this error is an illusion exile");

            var result = controller.CreateBuild(model: null);

            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("CreateNewBuild", redirectToActionResult.ActionName);
        }
    }
}