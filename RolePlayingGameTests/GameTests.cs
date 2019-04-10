using Moq;
using RolePlayingGame;
using Xunit;

namespace RolePlayingGameTests
{
    public class GameTests
    {
        Mock<Game> mockGame = new Mock<Game>();
        Mock<HumanPlayer> myPlayerMock = new Mock<HumanPlayer>();


        [Fact]
        public void TestIfWeCanCreateAndPlayAGame()
        {
            // Arrange
            HumanPlayer player = myPlayerMock.Object;
            Game game = mockGame.Object;

            // Act
            mockGame.Setup(mock => mock.PlayGame(player));

            // Assert
            mockGame.Verify(mock => mock.CreateGame(), Times.Once());
        }

    }
}
