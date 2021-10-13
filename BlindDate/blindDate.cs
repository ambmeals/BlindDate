using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindDate
{
    class blindDate
    {
        static void Main(string[] args)
        {
            gameTitle();

        }

        public static void gameTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
           string title =
                @"                   ____  __    ____  _  _  ____     ____    __   ____  ____ 
                  (  _ \(  )  (_  _)( \( )(  _ \   (  _ \  /__\ (_  _)( ___)
                   ) _ < )(__  _)(_  )  (  )(_) )   )(_) )/(__)\  )(   )__) 
                  (____/(____)(____)(_)\_)(____/   (____/(__)(__)(__) (____)";
                                                                  
            Console.WriteLine(title);
            Console.WriteLine("");
            Console.WriteLine("Welcome to your blind date!");
            Console.WriteLine("Select the numerical choices given in the game");
            Console.WriteLine("Press Enter to begin.");
            Console.WriteLine("");
            Console.ReadLine();
            Console.Clear();
            first();
        }



        public static void first()
        {
            string choice;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("It's your first blind date.\n" +
                "You recieve a text from your date...\n" +
                "'PLZ EAT B4 D8. I HAVE A SPECIAL DIET.'\n" +
                "Strange....but I guess understandable");
            Console.WriteLine("You arrive and greet your date.\n" +
                "They proceeed to pull a ziploc bag full of beets and eat it with a spoon.\n" +
                "They offer you a spoon....");
            Console.WriteLine("What do you do? ");
            Console.WriteLine("1. Grab the extra spoon, you love beets ");
            Console.WriteLine("2. Leave, WHAT THE HECK IS WRONG WITH THEM! ");
            Console.WriteLine("3. Cry ");
            Console.WriteLine("4. Get Drunk");
            Console.Write("Choice: 1 - 3 ");
            //ToLower () makes user input into lowercase
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                //you can call multiple case scenarios for the same block of code
                case "1":
                case "grab":
                
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You grab the extra spoon and chow down!.\n" +
                            "You can't believe how considerate your date is to share.");
                        Console.WriteLine("You think this might be the one.");
                        Console.WriteLine("They begin to chat with you about their favorite music");
                        Console.WriteLine("They mention the genre SKA and you quickly run out of the bar");
                        Console.WriteLine("Press 'ENTER' to continue. ");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }


                case "2":
                case "leave":
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("You tell them beets aren't your deal and hastly run out of the bar\n" +
                            "Shaking off the smell of beets, you continue your night onward.");
                        Console.WriteLine("Press Enter to continue....");
                        Console.ReadLine();
                        second();
                        break;
                    }


                case "3":
                case "cry":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("You start to tear and cry a little...");
                        Console.WriteLine("Your date tells you that you're making them uncomfortable and asks you to please leave.\n" +
                            "You begin to explain that beets remind you of your dead grandmother...."+
                            "\nIt's at this time you decide to leave. " +
                            "\nYou start walking outside along the sidewalk. ");
                        Console.WriteLine("Press Enter to continue....");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "4":
                case "ask":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("You tell the bartender to keep them coming");
                        Console.WriteLine("It's three hours into your date and you're having a pretty good time!\n" +
                            "You've had so much whiskey, even the SKA your date keeps playing is sounding like a bop.\n" +
                            "You feel queezy. You can't tell if it's from the beets or the liqour.");
                        Console.WriteLine("Press Enter to continue....");
                        Console.ReadLine();
                        fourth();
                        break;
                    }
                default:
                    {

                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("I don't understand that command....");
                            Console.WriteLine("Press 'Enter' to try again");
                            Console.ReadLine();
                            //call back to the first() to repeat question
                            first();
                            break;
                        }
                    }

            }


        }




        public static void second()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Random rnd = new Random();
            //string together random scenarios in an array to initiate a randomizer
            //this will pull a random index out of the array to get a random second statement 
            string[] secOptions = { "You begin walking down the street. You step in some gum. You start loudly cursing.\n People ask you to stop\nYou start chasing them", "You begin walking down the street, you hear loud vibey music. ", " You begin walking down the street, you see beautiful lights in the distance. " };
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];
            //this will pick a random index out of that array COOOL

            string secChoice;
            //outputting the secText variable 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(secText);
            Console.WriteLine("Do you continue forward?");
            Console.Write("Choice: yes or no ");
            //put user's choice into the secChoice variable
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                third();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("A meteor slams straight into the road at that exact moment, killing you instantly.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                gameOver();
            }
            //call another else, it's not 'N', it's not 'no', it's something unrecognized
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("I don't understand that command....");
                Console.WriteLine("Press 'Enter' to try again");
                Console.ReadLine();
                //call back to the second() to repeat question
                second();
            }

        }
        public static void third()
        {
            int age;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("You start running towards what you see and you run right into a RAVE!");
            Console.WriteLine("SUUURRRPPPRRRIIISSSEEE RAAAAAAVVVVVVVEEEE!");
            Console.WriteLine("There is a doorman asking for the password.");
            Console.WriteLine("You can't get in unless you're the correct 'AGE'.");
            Console.WriteLine("AGE: ");
            //asking console to parse this string into a number
            int.TryParse(Console.ReadLine(), out age);

            //this while loop will continue to loop until user guesses 42
            while (age < 42)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Seriously? I am not an idiot, to get in I need your correct age. \nIt's always the answer.");
                Console.WriteLine("Come on, how old are you really? ");
                Console.Write("Age: ");
                int.TryParse(Console.ReadLine(), out age);
            }



            Console.WriteLine("Wow, that wasn't so hard. You ready to dance?");
            youWin();
        }

        public static void fourth()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Random rnd = new Random();
            //string together random scenarios in an array to initiate a randomizer
            //this will pull a random index out of the array to get a random second statement 
            string[] fourOptions = { "You vomit in the toilet at the bar.\nEmbaressed, you run out of the bar.", "You vomit on your date at the bar\nEmbaressed, you run out of the bar.", "You vomit on the floor at the bar. \nEmbaressed, you run out of the bar." };
            int randomNumber = rnd.Next(0, 3);
            string fourText = fourOptions[randomNumber];
            //this will pick a random index out of that array COOOL

            string fourthChoice;
            //outputting the secText variable 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(fourText);
            Console.WriteLine("Do you continue forward?");
            Console.Write("Choice: yes or no ");
            //put user's choice into the secChoice variable
            fourthChoice = Console.ReadLine().ToLower();

            if (fourthChoice == "yes" || fourthChoice == "y")
            {
                second();
            }
            else if (fourthChoice == "no" || fourthChoice == "n")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("A meteor slams straight into the road at that exact moment, killing you instantly.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                gameOver();
            }
            //call another else, it's not 'N', it's not 'no', it's something unrecognized
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("I don't understand that command....");
                Console.WriteLine("Press 'Enter' to try again");
                Console.ReadLine();
                //call back to the second() to repeat question
                second();
            }
        }


        public static void gameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("This date did not go as expected....\n" +
                "You can't help but wonder if your choices would have changed the outcome." +
                              "\nBetter luck next time. ");
            Console.WriteLine("Press 'Enter' to try again");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void youWin()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You danced the night away and decide blind dates are overrated." +
                              "\nYou can't help but wonder if your date would have been different with different choices.");
            Console.WriteLine("\nPress 'Enter' to try again");
            Console.ReadLine();
            Console.Clear();
            gameTitle();

        }





    }
}