using Moq;
using RolePlayingGame;
using Xunit;

namespace RolePlayingGameTests
{
    public class GameTests
    {
        private Mock<HumanPlayer> myPlayerMock = new Mock<HumanPlayer>();
        private Mock<Game> mockGame = new Mock<Game>();


        [Fact]
        public void TestIfWeCanCreateAndPlayAGame()
        {
            // Arrange
            HumanPlayer player = myPlayerMock.Object;
            Game game = mockGame.Object;

            // Act
            mockGame.Setup(mock => mock.PlayGame());

            // Assert
            mockGame.Verify(mock => mock.CreateGame(), Times.Once());
        }

    }
}
