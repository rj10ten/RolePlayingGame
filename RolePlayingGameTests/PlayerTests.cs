using RolePlayingGame;
using Xunit;

namespace RolePlayingGameTests
{
    public class PlayerTests
    {
        HumanPlayer player = new HumanPlayer();

        [Fact]
        public void TestIfWeCanSetPlayerName()
        {
            // Arrange
            HumanPlayer player = new HumanPlayer();

            // Act
            player.Name = "Rajan";

            // Assert
            Assert.Equal("Rajan", player.Name);
        }

        [Fact]
        public void TestIfWeCanSetAPlayersLevel()
        {
            // Arrange

            // Act
            player.Level = 1;

            // Assert
            Assert.Equal(1, player.Level);
        }

        [Fact]
        public void TestIfWeCanSetAPlayersClassType()
        {
            // Arrange

            // Act
            player.ClassType = "Monk";

            // Assert
            Assert.Equal("Monk", player.ClassType);
        }

        [Fact]
        public void TestIfWeCanSetAPlayersClassLevel()
        {
            // Arrange

            // Act
            player.ClassLevel = 1;

            // Assert
            Assert.Equal(1, player.ClassLevel);
        }

        [Fact]
        public void TestIfWeCanSetPlayersMaxHealth()
        {
            // Arrange

            // Act
            player.MaxHealth = 10;

            // Assert
            Assert.Equal(10, player.MaxHealth);
        }

        [Fact]
        public void TestIfWeCanSetPlayersCurrentHealth()
        {
            // Arrange

            // Act
            player.CurrentHealth = 10;

            // Assert
            Assert.Equal(10, player.CurrentHealth);
        }
    }
}
