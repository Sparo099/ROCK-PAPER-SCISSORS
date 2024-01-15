using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROCKPAPERSCISSORS
{
    




namespace ROCKPAPERSCISSORS
    {
       static class Program
        {
            static void Main(string[] args)
            {
                string inputPlayer, inputCPU;
                int randomInt;

                bool playAgain = true;

                while (playAgain)
                {
                    // Initialize player and CPU scores for each round
                    int scorePlayer = 0;
                    int scoreCPU = 0;

                    // Continue playing until either player or CPU reaches a score of 3
                    while (scorePlayer < 3 && scoreCPU < 3)
                    {
                        // Get player input
                        Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");
                        inputPlayer = Console.ReadLine();
                        inputPlayer = inputPlayer.ToUpper();

                        // Generate random CPU choice (1 = ROCK, 2 = PAPER, 3 = SCISSORS)
                        Random rnd = new Random();
                        randomInt = rnd.Next(1, 4);

                        // Translate random CPU choice to ROCK, PAPER, or SCISSORS
                        switch (randomInt)
                        {
                            case 1:
                                inputCPU = "ROCK";
                                Console.WriteLine("Computer chose ROCK");
                                if (inputPlayer == "ROCK")
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "PAPER")
                                {
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "SCISSORS")
                                {
                                    Console.WriteLine("CPU WINS!!\n\n");
                                    scoreCPU++;
                                }
                                break;
                            case 2:
                                inputCPU = "PAPER";
                                Console.WriteLine("Computer chose PAPER");
                                if (inputPlayer == "PAPER")
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "ROCK")
                                {
                                    Console.WriteLine("CPU WINS!!\n\n");
                                    scoreCPU++;
                                }
                                else if (inputPlayer == "SCISSORS")
                                {
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                break;
                            case 3:
                                inputCPU = "SCISSORS";
                                Console.WriteLine("Computer chose SCISSORS");
                                if (inputPlayer == "SCISSORS")
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "ROCK")
                                {
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "PAPER")
                                {
                                    Console.WriteLine("CPU WINS!!\n\n");
                                    scoreCPU++;
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid entry!");
                                break;
                        }

                        // Display current scores
                        Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);
                    }

                    // Determine the winner of the game
                    if (scorePlayer == 3)
                    {
                        Console.WriteLine("Player WON!");
                    }
                    else if (scoreCPU == 3)
                    {
                        Console.WriteLine("CPU WON!");
                    }
                    else
                    {
                        // This block is not needed as it won't be executed.
                    }

                    // Ask the user if they want to play again
                    Console.WriteLine("Do you want to play again? (y/n)");
                    string loop = Console.ReadLine();
                    if (loop == "y")
                    {
                        playAgain = true;
                        Console.Clear();
                    }
                    else if (loop == "n")
                    {
                        playAgain = false;
                    }
                    else
                    {
                        // This block is not needed as it won't be executed.
                    }
                }
            } } } }
        
    

