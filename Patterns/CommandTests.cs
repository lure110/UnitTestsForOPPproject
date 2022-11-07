using csgame_backend.player_websocket;
using Xunit;
using Assert = Xunit.Assert;

namespace csgame_backend.csgame_backend.Patterns.Tests
{
    public class CommandTests
    {
       [Fact]
        public void CommandTest()
        {
            //Assert.Fail();
        }

        [Fact]
        public void ExecuteTest()
        {
            Player player1 = new Player("Unit_Test_Player1", 0, 0);
            Player player2 = new Player("Unit_Test_Player2", 0, 0);

            Shoot shoot = new Shoot();
            shoot.ExecuteCommand(10f,player2);
            player1.Health -= 10f;

            bool same = player1.Health == player2.Health;

            Assert.True(same, "Player1 health: " + player1.Health + "should be same as Player2 health: "+player2.Health);
        }

        [Fact]
        public void UnExecuteTest()
        {
            Player player1 = new Player("Unit_Test_Player1", 0, 0);
            Player player2 = new Player("Unit_Test_Player2", 0, 0);

            Shoot shoot = new Shoot();
            shoot.ExecuteCommand(10f, player2);
            shoot.UnExecuteCommand(player2);

            bool same = player1.Health == player2.Health;

            Assert.True(same, "Player1 health: " + player1.Health + "should be same as Player2 health: " + player2.Health);
        }
    }
}