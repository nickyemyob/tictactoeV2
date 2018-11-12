using FluentAssertions;
using Xunit;

namespace TicTacToe.Tests
{
    public class GameShould
    {
        [Fact]
        public void DetermineWhichPlayersTurnItIs()
        {
            IPlayer player = new StubPlayer();
            IGame game = new Game();
            IGameState gameState = new GameState();

            var currentPlayer = game.CurrentPlayer();

            currentPlayer.Should().Be("");
        }
    }

    public class GameState : IGameState
    {
    }

    public interface IGameState
    {
    }

    public class Game : IGame
    {
        public object CurrentPlayer()
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IGame
    {
        object CurrentPlayer();
    }

    public class StubPlayer : IPlayer
    {
    }

    public interface IPlayer
    {
    }
}