using Microsoft.VisualStudio.TestTools.UnitTesting;
using RolePlayingGame;

namespace RolePlayingGameTests
{
    [TestClass]
    public class PlayerTests
    {
        HumanPlayer player = new HumanPlayer();

        [TestMethod]
        public void TestIfWeCanSetPlayerName()
        {
            // Arrange

            // Act
            player.Name = "Rajan";

            // Assert
            Assert.AreEqual("Rajan", player.name);
        }

        [TestMethod]
        public void TestIfWeCanSetAPlayersLevel()
        {
            // Arrange

            // Act
            player.Level = 1;

            // Assert
            Assert.AreEqual(1, player.level);
        }

        [TestMethod]
        public void TestIfWeCanSetAPlayersClassType()
        {
            // Arrange

            // Act
            player.ClassType = "Monk";

            // Assert
            Assert.AreEqual("Monk", player.classType);
        }

        [TestMethod]
        public void TestIfWeCanSetAPlayersClassLevel()
        {
            // Arrange

            // Act
            player.ClassLevel = 1;

            // Assert
            Assert.AreEqual(1, player.classLevel);
        }

        [TestMethod]
        public void TestIfWeCanSetPlayersMaxHealth()
        {
            // Arrange

            // Act
            player.MaxHealth = 10;

            // Assert
            Assert.AreEqual(10, player.maxHealth);
        }

        [TestMethod]
        public void TestIfWeCanSetPlayersCurrentHealth()
        {
            // Arrange

            // Act
            player.CurrentHealth = 10;

            // Assert
            Assert.AreEqual(10, player.currentHealth);
        }
    }
}
