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

        [Fact]
        public void Able_to_select_position_on_board()
        {
            // Arrange
            Position selectedPosition = Player.PositionForNumber(9);

            Board testGameBoard = new Board();



            // Act
            string index = testGameBoard.GameBoard[selectedPosition.Row,selectedPosition.Column];

            // Assert
            Assert.Equal("9", index);
        }

        [Fact]
        public void GameWinner()
        {
            //Arrange
            
            Player player1 = new Player();
            Player player2 = new Player();
            Game startNewGame = new Game(player1, player2);

            Board testBoard = new Board();
         
            //Act we need players to play and start the game and the testboard

            bool winningGame = startNewGame.CheckForWinner(null);

            //Assert
            Assert.False(winningGame);

        }
        [Fact]
        public void Cannot_enter_index_above_nine()
        {
            Assert.Null(Player.PositionForNumber(10));
        }
    }
}
