using Lab04_TicTacToe.Classes;
using System;
using System.Threading;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Tic-Tac-Toe Game!");
            StartGame();
        }

       
        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Console.WriteLine("test");

        

            //Ask For Player Names
            Console.WriteLine("Player 1: What is your Name?");
            string userInput1 = Console.ReadLine();
            Player player1 = new Player();
            player1.Name = userInput1;
            player1.Marker = "X";
            player1.IsTurn = true;

            Console.WriteLine("Player 2: What is your name?");
            string userInput2 = Console.ReadLine();
            Player player2 = new Player();
            player2.Name = userInput2;
            player2.Marker = "O";
            player2.IsTurn = false;

            Game newGame = new Game(player1, player2);
           newGame.Play();
        

        }


    }
}
