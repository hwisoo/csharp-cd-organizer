using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CdOrganizer.Controllers;
using CdOrganizer.Models;

namespace CdOrganizer.Tests
{
    [TestClass]
    public class ArtistsControllerTest
    {
             [TestMethod]
        public void Create_ReturnsCorrectActionType_RedirectToActionResult()
        {
            //Arrange
            ArtistsController controller = new ArtistsController();

            //Act
            IActionResult view = controller.Create("Walk the dog");

            //Assert
            Assert.IsInstanceOfType(view, typeof(ActionResult));
        }

        // [TestMethod]
        // public void Create_RedirectsToCorrectAction_Index()
        // {
        //     //Arrange
        //     ArtistsController controller = new ArtistsController();
        //     RedirectToActionResult actionResult = controller.Create("Walk the dog") as RedirectToActionResult;

        //     //Act
        //     string result = actionResult.ActionName;

        //     //Assert
        //     Assert.AreEqual(result, "Index");
        // }
    }
}
