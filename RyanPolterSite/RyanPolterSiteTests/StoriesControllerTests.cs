using Microsoft.AspNetCore.Mvc;
using RyanPolterSite.Controllers;
using RyanPolterSite.Models;
using System;
using Xunit;

namespace RyanPolterSiteTests
{
    public class StoriesControllerTests
    {
        //  Note: Fact is to xUnit as Test is to nUnit
        [Fact]
        public void IndexTest()
        {
            const string TITLE = "Story Title";

            // The three A's
            //  Arrange
            //  Act
            //  Assert

            //  Arrange
            StoriesController controller = new StoriesController();

            //  Act
            //  Var is used if you dont remember what return is -> changed to IActionResult
            ViewResult viewResult = (ViewResult)controller.Index(TITLE, "The topic at hand", 2006, "Here is all the story text", "Submitter", DateTime.Now);

            StoriesModel model = (StoriesModel)viewResult.Model;

            //  Assert
            Assert.NotNull(viewResult);
            Assert.Equal("Story Title", model.StoryTitle);
        }
    }
}
