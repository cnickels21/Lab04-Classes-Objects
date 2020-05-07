using Lab04_TicTacToe.Classes;
using System;
using Xunit;

namespace Lab04_TicTacToeTests
{
    public class Lab04_TicTacToeTests
    {
        [Fact]
        public void Check_that_next_turn_is_valid()
        {
            // Arrange
            Player player1 = new Player();
            player1.Name = "Chase";

            Player player2 = new Player();
            player2.Name = "Marie";

            player1.IsTurn = true;
            player2.IsTurn = false;

            

            // Act
            Game testGameBoard = new Game(player1, player2);
            Player current = testGameBoard.NextPlayer();

            // Assert
            Assert.Equal("Chase", current.Name);
        }
    }
}
