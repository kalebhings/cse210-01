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

                /* Instructions */
                startGame(playerTurn);

                /* creates board */
                displayBoard(boardSlot);

                /* Player chooses where to make move */
                makeMove(boardSlot, playerTurn);

                /* Check if there is a win or a draw */
                game = checkWinner(boardSlot);

           } while (game.Equals(0));
        }

        private static int checkWinner(char[] boardSlot)
        {
            if (hasWinner(boardSlot))
            {
                return 1;
            }

            if (isDraw(boardSlot))
            {
                return 2;
            }

            return 0;
        }
        private static bool isDraw(char[] boardSlot)
        {   
            /* Check if all game markers are replaced by "O" or "X" */
            return boardSlot[0] != '1' &&
                   boardSlot[1] != '2' &&
                   boardSlot[2] != '3' &&
                   boardSlot[3] != '4' &&
                   boardSlot[4] != '5' &&
                   boardSlot[5] != '6' &&
                   boardSlot[6] != '7' &&
                   boardSlot[7] != '8' &&
                   boardSlot[8] != '9';
        }
        private static bool hasWinner(char[] boardSlot)
        {   
            /* Checks to see if there is a winner*/
             if (IsSlotPlacementTheSame(boardSlot, 0, 1, 2))
            {
                return true;
            }

            if (IsSlotPlacementTheSame(boardSlot, 3, 4, 5))
            {
                return true;
            }

            if (IsSlotPlacementTheSame(boardSlot, 6, 7, 8))
            {
                return true;
            }

            if (IsSlotPlacementTheSame(boardSlot, 0, 3, 6))
            {
                return true;
            }

            if (IsSlotPlacementTheSame(boardSlot, 1, 4, 7))
            {
                return true;
            }

            if (IsSlotPlacementTheSame(boardSlot, 2, 5, 8))
            {
                return true;
            }

            if (IsSlotPlacementTheSame(boardSlot, 0, 4, 8))
            {
                return true;
            }

            if (IsSlotPlacementTheSame(boardSlot, 2, 4, 6))
            {
                return true;
            }

            return false;
        }

        private static bool IsSlotPlacementTheSame(char[] testSlotPlacement, int pos1, int pos2, int pos3)
        {
            return testSlotPlacement[pos1].Equals(testSlotPlacement[pos2]) && testSlotPlacement[pos2].Equals(testSlotPlacement[pos3]);
        }

        private static void makeMove(char[] boardSlot, int currentPlayer)
        {   
            bool notValidMove = true;

            do
            {
                string userInput = Console.ReadLine();

                if (!string.IsNullOrEmpty(userInput) &&
                    (userInput.Equals("1") ||
                    userInput.Equals("2") ||
                    userInput.Equals("3") ||
                    userInput.Equals("4") ||
                    userInput.Equals("5") ||
                    userInput.Equals("6") ||
                    userInput.Equals("7") ||
                    userInput.Equals("8") ||
                    userInput.Equals("9")))
                {

                    int.TryParse(userInput, out var slotPlacement);

                    char currentTurn = boardSlot[slotPlacement - 1];

                    if (currentTurn.Equals('X') || currentTurn.Equals('O'))
                    {
                        Console.WriteLine("Selection already taken, please try a new spot.");
                    }
                    else
                    {
                        boardSlot[slotPlacement - 1] = nextPlayer(currentPlayer);

                        notValidMove = false;
                    }
                }
            } while (notValidMove);
        }

        private static char nextPlayer(int player)
        {
            if(player % 2 == 0)
            {
                return 'O';
            }

            return 'X';
        }

        static void startGame(int playerNumber)
        {
            Console.WriteLine("Player 1: X");
            Console.WriteLine("Player 2: O");
            Console.WriteLine("");

            Console.WriteLine($"Player {playerNumber} to move, select 1 through 9 from the game board");
            Console.WriteLine("");
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

