using Microsoft.VisualStudio.TestTools.UnitTesting;
using RolePlayingGame;

namespace RolePlayingGameTests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void TestIfWeCanSetPlayerName()
        {
            // Arrange
            HumanPlayer player = new HumanPlayer();

            // Act
            player.Name = "Rajan";

            // Assert
            Assert.AreEqual("Rajan", player.name);
        }

        [TestMethod]
        public void TestIfWeCanSetAPlayersLevel()
        {
            // Arrange
            HumanPlayer player = new HumanPlayer();

            // Act
            player.Level = 1;

            // Assert
            Assert.AreEqual(1, player.level);
        }

        [TestMethod]
        public void TestIfWeCanSetAPlayersClassType()
        {
            // Arrange
            HumanPlayer player = new HumanPlayer();

            // Act
            player.ClassType = "Monk";

            // Assert
            Assert.AreEqual("Monk", player.classType);
        }

        [TestMethod]
        public void TestIfWeCanSetAPlayersClassLevel()
        {
            // Arrange
            HumanPlayer player = new HumanPlayer();

            // Act
            player.ClassLevel = 1;

            // Assert
            Assert.AreEqual(1, player.classLevel);
        }
    }
}
