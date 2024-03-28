using System;

namespace Project_Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
        Loop:
            Console.Clear();
            Console.WriteLine("Project Hangman!");         
            Console.WriteLine("         Welcome Hangman");
            Console.WriteLine("Press 1 to Start the Game.");
            Console.WriteLine("Press 2 for Instruction.");
            Console.WriteLine("Press 3 to Exit the Game.");
            int first_button = int.Parse(Console.ReadLine());
            string[] word = { "a" };
            int index = 0;
            if (first_button == 1)
            {
                Console.WriteLine("For Single Player Press 1\nFor Multiplayer Press 2");
                int player = int.Parse(Console.ReadLine());
                if (player==1)
                {
                    Console.WriteLine("Choose level of game by pressing the number\n1. Easy\n2. Normal\n3. Difficult\n4. Extrem");
                    int level = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Write any word from the list given below");
                    switch (level)
                    {
                        case 1:
                            word = new string[10] { "phone", "jug", "doggy", "space", "moon", "book", "chair", "kitchen", "glass", "laptop" };
                            Random rand = new Random();
                            index = rand.Next(word.Length);
                            Console.WriteLine("phone, jug, doggy, space, moon, book, chair, kitchen, glass, laptop");
                            break;
                        case 2:
                            word = new string[10] { "character", "country", "university", "conquest", "dragonstone", "defensive", "strength", "thousand", "revierside", "processor" };
                            Random rand2 = new Random();
                            index = rand2.Next(word.Length);
                            Console.WriteLine("character, country, university, conquest,dragonstone, defensive, strength, thousand, revierside, processor");
                            break;
                        case 3:
                            word = new string[10] { "fundamental", "nutritional", "license", "expensive", "archmaester", "interface", "modification", "prototype", "targaryen", "argument" };
                            Random rand3 = new Random();
                            index = rand3.Next(word.Length);
                            Console.WriteLine("fundamental, nutritional, license, expensive, archmaester, interface, modification, prototype, targaryen, argument");
                            break;
                        case 4:
                            word = new string[10] { "fundamental", "nutritional", "license", "expensive", "archmaester", "interface", "modification", "prototype", "targaryen", "argument" };
                            Random rand4 = new Random();
                            index = rand4.Next(word.Length);
                            Console.WriteLine("fundamental, nutritional, license, expensive, archmaester, interface, modification, prototype, targaryen, argument");
                            break;
                        default:
                            Console.WriteLine("You have Entered the Wrong digit Press enter to go back to Menu");
                            Console.ReadLine();
                            goto Loop;
                    }

                }
                else if (player==2)
                {
                    Console.Clear();
                    Console.WriteLine("First Player Enter the Word");
                    word = new string[1] { Console.ReadLine() };
                    Console.WriteLine("First Player Enter the hint for Second Player");
                    string hint = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Hint is "+hint);
                }
                
                string first_word = $"{word[index]}";
                string wordreplace = first_word.Replace(first_word, "*******");
                Console.WriteLine(wordreplace);
                int guesscount = 0;
                int Score = 100;
                string Guessword = Console.ReadLine();
                do
                {
                    if (first_word == Guessword)
                    {
                        Console.Clear();
                        Console.WriteLine("\nCorrect Word. You win.");
                        Console.WriteLine("Guess word is "+first_word);
                        
                        Console.WriteLine("Your Score is " + Score + " out of 100");
                        
                    }
                    else if (first_word != Guessword)
                    {
                        Console.WriteLine("Wrong Word Try Again.");
                        guesscount++;
                        Score-=10;
                        Guessword = Console.ReadLine();
                    }

                } while (first_word!= Guessword && guesscount <=10);
                if (first_word == Guessword)
                {
                    Console.Clear();                    
                    Console.WriteLine("Correct Word. You win.");
                    Console.WriteLine("Guess word is " + first_word);
                    Console.WriteLine("Your Score is " + Score + " out of 100");
                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Words. You have lost the game.");
                    Console.WriteLine("Correct word is " + first_word);
                    
                }
                Console.WriteLine("\nif you want to play again press 1 or to end the game press 2");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        goto Loop;
                    case 2:
                        break;
                    default:
                        Console.WriteLine("You have Entered the Wrong digit Press enter to go back to Menu");
                        Console.ReadLine();
                        goto Loop;
                }
            }       
            else if  (first_button == 2)
            {
                Console.Clear();
                Console.WriteLine(" Game Instructions");
                Console.WriteLine();
                Console.WriteLine("For Single Player:\n\nFirst player will give a word with hint, the second player will guess the word\n" +
                    "if the word is wrong try again, second player will have 10 chances to guess the word if all chance are used then the \n" +
                    "game will end and the Score will be shown, if the word is right the score will be shown.\n\n" +
                    "For Multi Player:\n\nSystem will give you a list of word, you have to choose the word from the \n" +
                    "list, if the word is correct the score will be shown but if the word is wrong system will let you try once again, \n" +
                    "the player will have 10 chances to guess the word if all chances are used the system will show the result.\n");
                Console.WriteLine("\nif you want to play again press 1 or to end the game press 2");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        goto Loop;
                    case 2:
                        break;
                    default:
                        Console.WriteLine("\nYou have Entered the Wrong digit Press enter to go back to Menu");
                        Console.ReadLine();
                        goto Loop;
                }
            }
            else if (first_button==3)
            {
                Console.Clear();
                Console.WriteLine("\nPress Enter to Exit the Game");
            }
            Console.ReadKey();
        }
    }
}
