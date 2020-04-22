﻿using System.CodeDom.Compiler;
using System;

namespace GuessingGame
{
    class Program
    {   
        // Method that generates a random number
        static int Random_Number_Generator(int x, int y)
        {
            Random random = new Random();
            int randomNumber = random.Next(x, y);
            return randomNumber;

        }
        //Main Program
        static void Main(string[] args)
        {
    
            {
                Console.WriteLine("Welcome to Mikki Number Guessing Game");
                Console.WriteLine("Enter the number against the levels to select a level.");
                //Prompts user to select a level
                Console.WriteLine("Select a level:");
                int Level = int.Parse(Console.ReadLine());
            

                if (Level == 1)
                {
                    Console.WriteLine("***** Level 1 *****");
                    Console.WriteLine("In this level, you are expected to guess a number between 0 and 10. You have 6 chances. Goodluck!");
                    //Stores the random number generated by the Method in a variable Random_Number
                    int Random_Number = Random_Number_Generator(1, 10);
                    //Allows the user to attempt guessing the right number up to six times
                    for(int i =1; i < 7; i++)
                    {
                    try
                    {
                        //Prompts user to enter a number and stores the number in the guess variable
                        Console.WriteLine("Guess a Number:");
                        int Guess =int.Parse(Console.ReadLine());
                        //Compares the users guess with the random number
                        if(Guess ==Random_Number )
                        {
                            Console.WriteLine("You got it right!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That was wrong!, You have made " + i + " out of 6 chances");  
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }    
                    if (i == 6)
                    {
                
                        Console.WriteLine("Game Over!");
                    }
               }
                }
                
            
        
        
                else if (Level == 2)
                {
                    Console.WriteLine("***** Level 2 *****");
                    Console.WriteLine("In this level, you are expected to guess a number between 0 and 20.You have 4 chances. Goodluck!");
                    //Stores the random number generated by the Method in a variable Random_Number
                    int Random_Number = Random_Number_Generator(1, 20);
                    //Allows the user to attempt guessing the right number up to four times
                    for(int i =1; i < 5; i++)
                    {
                    try
                    {
                        //Prompts user to enter a number and stores the number in the guess variable
                        Console.WriteLine("Guess a Number:");
                        int Guess =int.Parse(Console.ReadLine());
                        //Compares the user's guess with the random number                
                        if(Guess == Random_Number)
                        {
                            Console.WriteLine("You got it right!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That was wrong! You have made " + i + " out of 4 chances");
                
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }    
                    if (i == 4)
                    {
                        Console.WriteLine("Game Over!");
                    }
                }    
                }

                else if (Level == 3)
                {   
                    Console.WriteLine("***** Level 3 *****");
                    Console.WriteLine("In this level, you are expected to guess a number between 0 and 50.You have 3 chances. Goodluck!"); 
                    //Stores the random number generated by the Method in a variable Random_Number
                    int Random_Number = Random_Number_Generator(1, 50); 
                    //Allows the user to attempt guessing the right number up to three times              
                    for(int i =1; i < 4; i++)
                    {
                    try
                    {

                        //Prompts user to enter a number and stores the number in the guess variable
                        Console.WriteLine("Guess a Number:");
                        int Guess =int.Parse(Console.ReadLine());
                        //Compares the users guess with the random number
                        if(Guess == Random_Number)
                        {
                            Console.WriteLine("You got it right!");
                        }
                        else
                        {
                            Console.WriteLine("That was wrong! You have made " + i + " out of 3 chances");
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }    
                    if (i==3)
                    {
                        Console.WriteLine("Game Over!");
                    }

                    }
                    
                }

            }   
            
            
        }   
    }
}


