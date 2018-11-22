using FluentAssertions;
using Xunit;

namespace TicTacToe.Tests
{
    public class GameShould
    {
        [Fact]
        public void AllowPlayerToPlaceAMoveOnTheBoard()
        {
            IPlayer player = new Player();
            IGameState gameState = new GameState();
            IGame game = new Game(gameState);

            var actualGameState = game.ChangeState(player);
            var expectedGameState = new[,]
            {
                {"x"," "," "},
                {" "," "," "},
                {" "," "," "}
            };

            actualGameState.Should().Be(expectedGameState);
        }
    }

    public class Game : IGame
    {
        public Game(IGameState gameState)
        {
            throw new System.NotImplementedException();
        }

        public object ChangeState(IPlayer player)
        {
            throw new System.NotImplementedException();
        }
    }

    public class GameState : IGameState
    {
    }


    public class Player : IPlayer
    {
    }

    public interface IGameState
    {
    }

    public interface IGame
    {
        object ChangeState(IPlayer player);
    }

    public interface IPlayer
    {
    }
}