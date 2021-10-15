using System;

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

            Print(title, 10);
            Console.WriteLine("");
            Print("  Welcome to your blind date!", 10);
            Print("  Select the numerical choices given in the game", 10);
            Print("  Press Enter to begin.", 10);
            Console.WriteLine("");
            Console.ReadLine();
            Console.Clear();
            first();
        }



        public static void first()
        {
            string choice;
            Console.ForegroundColor = ConsoleColor.Green;
            Print("It's your first blind date.\n" +
                "You recieve a text from your date...\n" +
                "'PLZ EAT B4 D8. I HAVE A SPECIAL DIET.'\n" +
                "Strange....but I guess understandable", 30);
           Print("You arrive and greet your date.\n" +
                "They proceeed to pull out a ziploc bag full of beets and eat it with a spoon.\n" +
                "They offer you a spoon....", 30);
            Print("What do you do? ", 30);
            Console.WriteLine("");
            Print("1. Grab the extra spoon. YOU LOVE BEETS! ", 30);
            Print("2. Leave, WHAT THE HECK IS WRONG WITH THEM! ", 30);
            Print("3. Cry ", 30);
            Print("4. Get Drunk", 30);
            Print("Choice: 1 - 4 ", 30);
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
                        Print("You grab the extra spoon and chow down!\n" +
                            "You can't believe how considerate your date is to share.", 30);
                        Print("You think this might be the one.", 30);
                        Print("They begin to chat with you about their favorite music.\n" +
                            "Who doesn't love music?", 30);
                        Print("They mention they love SKA and are a Sound Cloud rapper. \n" +
                            "Horrified, you quickly run out of the bar...", 30);
                        Console.WriteLine("");
                        Print("Press 'ENTER' to continue. ", 30);
                        Console.ReadLine();
                        fifth();
                        break;
                    }


                case "2":
                case "leave":
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Print("You tell them beets aren't your deal and hastly run out of the bar\n" +
                            "Shaking off the smell of beets, you continue your night onward.", 30);
                        Console.WriteLine("");
                        Print("Press Enter to continue....", 30);
                        Console.ReadLine();
                        fifth();
                        break;
                    }


                case "3":
                case "cry":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Print("You start to tear and cry a little...", 30);
                        Print("Your date tells you that you're making them uncomfortable and asks you to please leave.\n" +
                            "You begin to explain that beets remind you of your dead grandmother...." +
                            "\nIt's at this time you decide to leave. " +
                            "\nYou start walking outside along the sidewalk.", 30);
                        Console.WriteLine("");
                        Print("Press Enter to continue....", 30);
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "4":
                case "ask":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Print("You tell the bartender to keep them coming", 30);
                        Print("It's three hours into your date and you're having a pretty good time!\n" +
                            "You've had so much whiskey, even the SKA your date keeps playing is sounding like a bop.\n" +
                            "You feel queezy. You can't tell if it's from the beets or the liqour.", 30);
                        Console.WriteLine("");
                        Print("Press Enter to continue....", 30);
                        Console.ReadLine();
                        fourth();
                        break;
                    }
                default:
                    {

                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Print("I don't understand that command....", 30);
                            Console.WriteLine("");
                            Print("Press 'Enter' to try again", 30);
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
            string[] secOptions = 
                {"You begin walking down the street. You step in some gum. You start loudly cursing.\n " +
                "People ask you to stop\nYou start chasing them",
                "You begin walking down the street, you hear loud vibey music. It's such a vibe." +
                "What could possibly be playing such bops?",
                "You begin walking down the street, you see beautiful lights in the distance.\n" +
                "You feel like a stright up moth. You love lamp." };
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];
            //this will pick a random index out of that array COOOL

            string secChoice;
            //outputting the secText variable 
            Console.ForegroundColor = ConsoleColor.Blue;
            Print(secText, 30);
            Print("Do you continue forward?", 30);
            Console.WriteLine("");
            Print("Choice: yes or no", 30);
            //put user's choice into the secChoice variable
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                third();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Print("A meteor slams straight into the road at that exact moment, killing you instantly.", 30);
                Console.WriteLine("");
                Print("Press 'Enter' to continue.", 30);
                Console.ReadLine();
                gameOver();
            }
            //call another else, it's not 'N', it's not 'no', it's something unrecognized
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Print("I don't understand that command....", 30);
                Console.WriteLine("");
                Print("Press 'Enter' to try again", 30);
                Console.ReadLine();
                //call back to the second() to repeat question
                second();
            }

        }
        public static void third()
        {
            int age;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Print("You start and you run right into a RAVE!", 30);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Print("SUUURRRPPPRRRIIISSSEEE RAAAAAAVVVVVVVEEEE!", 30);
            Console.ForegroundColor = ConsoleColor.Red;
            Print("There is a doorman asking for the password.", 30);
            Print("You can't get in unless you're the correct 'AGE'.", 30);
            Console.WriteLine("");
            Print("AGE: ", 30);
            //asking console to parse this string into a number
            int.TryParse(Console.ReadLine(), out age);

            //this while loop will continue to loop until user guesses 42
            while (age < 42)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Print("Seriously? I am not an idiot, to get in I need your correct age. \nIt's always the answer.", 30);
                Print("Come on, how old are you really? ", 30);
                Console.WriteLine("");
                Print("Age: ", 30);
                int.TryParse(Console.ReadLine(), out age);
            }



            Print("Wow, that wasn't so hard. You ready to dance?", 30);
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
            Print(fourText, 30);
            Print("Do you continue forward?", 30);
            Console.WriteLine("");
            Print("Choice: yes or no ", 30);
            //put user's choice into the secChoice variable
            fourthChoice = Console.ReadLine().ToLower();

            if (fourthChoice == "yes" || fourthChoice == "y")
            {
                second();
            }
            else if (fourthChoice == "no" || fourthChoice == "n")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Print("A meteor slams straight into the road at that exact moment, killing you instantly.", 30);
                Console.WriteLine("");
                Print("Press 'Enter' to continue.", 30);
                Console.ReadLine();
                gameOver();
            }
            //call another else, it's not 'N', it's not 'no', it's something unrecognized
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Print("I don't understand that command....", 30);
                Console.WriteLine("");
                Print("Press 'Enter' to try again", 30);
                Console.ReadLine();
                //call back to the second() to repeat question
                second();
            }
        }





        public static void gameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Print("This date did not go as expected....\n" +
                "You can't help but wonder if your choices would have changed the outcome." +
                              "\nBetter luck next time. ", 30);
            Console.WriteLine("");
            Print("Press 'Enter' to try again", 30);
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void youWin()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Print("You danced the night away and decide blind dates are overrated." +
                              "\nYou can't help but wonder if your date would have been different with different choices.", 30);
            Console.WriteLine("");
            Print("\nPress 'Enter' to try again", 30);
            Console.ReadLine();
            Console.Clear();
            gameTitle();

        }



        public static void fifth()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Random rnd = new Random();
            string[] fiveOptions = {"You are thinking to yourself, how could this date have gone so wrong?\n" +
                "Lost in your thoughts, you bump into someone\n" +
                "You strike a conversation and they invite you to join them for an evening at the circus.\n" +
                "I mean why not? Nothing weirder could happen tonight.", "You are thinking to yourself that maybe you judged their diet harshly.\n Lost in your thoughts, you bump right into someone\n" +
                "You apologize but they reassure you it's alright\n" +
                "You have a nice chat and they invite you to the circus, they have an extra ticket.\n" +
                "" };
            int randomNumber = rnd.Next(0, 3);
            string fiveText = fiveOptions[randomNumber];
            //this will pick a random index out of that array COOOL

            string fiveChoice;
            //outputting the secText variable 
            Console.ForegroundColor = ConsoleColor.Blue;
            Print(fiveText, 30);
            Print("Do you continue forward?", 30);
            Console.WriteLine("");
            Print("Choice: yes or no ", 30);
            //put user's choice into the secChoice variable
            fiveChoice = Console.ReadLine().ToLower();

            if (fiveChoice == "yes" || fiveChoice == "y")
            {
                six();
            }
            else if (fiveChoice == "no" || fiveChoice == "n")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Print("A meteor slams straight into the road at that exact moment, killing you instantly.", 30);
                Console.WriteLine("");
                Print("Press 'Enter' to continue.", 30);
                Console.ReadLine();
                gameOver();
            }
        }

        public static void six()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Random rnd = new Random();
            string[] sixOptions = {"It turns out your new 'date' loves clowns...\n" +
                    "I mean they're leaning over the railing screaming 'I LOVE YOU' directly at the clowns\n" +
                "Everyone around seems uncomfortable....especially the clowns...\n",
                "Your new date seems to be going well.\n" +
                "You can't help but feel uncomfortable though...\n Your date won't stop cheering on the clowns.\n",
                "Your new date has officially given you the 'ICK'\n" + "Your date mentioned that they liked the circus...\n" +
                "How could you have known it would turn into 60 min of chanting on ONLY the clowns?"};
             
            int randomNumber = rnd.Next(0, 3);
            string sixText = sixOptions[randomNumber];
            //this will pick a random index out of that array COOOL

            string sixChoice;
            //outputting the secText variable 
            Console.ForegroundColor = ConsoleColor.Blue;
            Print(sixText, 30);
            Print("Should you leave?", 30);
            Console.WriteLine("");
            Print("Choice: yes or no ", 30);
            //put user's choice into the secChoice variable
            sixChoice = Console.ReadLine().ToLower();

            if (sixChoice == "yes" || sixChoice == "y")
            {
                second();
            }
            else if (sixChoice == "no" || sixChoice == "n")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Print("A meteor slams straight into the road at that exact moment, killing you instantly.", 30);
                Console.WriteLine("");
                Print("Press 'Enter' to continue.", 30);
                Console.ReadLine();
                gameOver();
            }


        }

        public static void Print(string text, int speed)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();

        }

    }
}