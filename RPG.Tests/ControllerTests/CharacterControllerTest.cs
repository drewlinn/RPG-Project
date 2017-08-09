using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RPG.Controllers;
using RPG.Models;
using Xunit;

namespace RPG.Tests
{
    public class CharacterControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            CharacterController controller = new CharacterController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            CharacterController controller = new CharacterController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<List<Character>>(result);
        }
    }
}