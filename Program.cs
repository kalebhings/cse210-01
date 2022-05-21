// cse210-01 Tic-Tac-Toe Assignment
// Kaleb Hingsberger
using System;
using System.Collections.Generic;

namespace cse210_01
{
    class Program
    
    {
        static void Main(string[] args)
        {
            int game = 0;
            int playerTurn = -1;
            char[] boardSlot = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};

           do
           {
               Console.Clear();
                /* initial player */
                playerTurn = newTurn(playerTurn);

                /* creates board */
                displayBoard(boardSlot);


           } while (game.Equals(0));
        }


        static void displayBoard(char[] boardSlot)
        {
            Console.WriteLine($" {boardSlot[0]} | {boardSlot[1]} | {boardSlot[2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {boardSlot[3]} | {boardSlot[4]} | {boardSlot[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {boardSlot[6]} | {boardSlot[7]} | {boardSlot[8]} ");
            Console.WriteLine("---+---+---");
        }
    
        static int newTurn(int player)
        {
            if (player.Equals(1))
            {
                return 2;
            }

            return 1;
        }
    }
}

