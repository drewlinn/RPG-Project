using RPG.Models;
using Xunit;

namespace RPG.Tests
{
    public class CharacterTest
    {
        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var character = new Character();
            character.name = "Kevin";
            //Act
            var result = character.name;

            //Assert
            Assert.Equal("Kevin", result);
        }
    }
}