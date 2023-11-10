using System;

namespace BlindDate
{
    class BlindDate
    {
        static void Main(string[] args)
        {
            DisplayGameTitle();
        }

        private static void DisplayGameTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(GetTitleArt());
            DisplayTextWithBlankLine("Welcome to your blind date adventure!");
            DisplayTextWithBlankLine("Press Enter to begin.");

            Console.ReadLine();
            Console.Clear();
            FirstEncounter();
        }

        private static string GetTitleArt()
        {
            return @"
   @""                   ____  __    ____  _  _  ____     ____    __   ____  ____ 
                  (  _ \(  )  (_  _)( \( )(  _ \   (  _ \  /__\ (_  _)( ___)
                   ) _ < )(__  _)(_  )  (  )(_) )   )(_) )/(__)\  )(   )__) 
                  (____/(____)(____)(_)\_)(____/   (____/(__)(__)(__) (____)"";
";
        }

        private static void DisplayTextWithBlankLine(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine();
        }

        private static void FirstEncounter()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            DisplayTextWithBlankLine("It's your first blind date...");
            DisplayTextWithBlankLine("You receive a text from your date...");
            DisplayTextWithBlankLine("'PLZ EAT B4 D8. I HAVE A SPECIAL DIET.'");
            DisplayTextWithBlankLine("Strange....but I guess understandable.");
            DisplayTextWithBlankLine("You arrive and greet your date.");
            DisplayTextWithBlankLine("They proceed to pull a ziploc bag full of beets and eat it with a spoon.");
            DisplayTextWithBlankLine("They offer you a spoon....");

            Console.WriteLine("What do you do?");
            Console.WriteLine("1: Grab the extra spoon, you love beets");
            Console.WriteLine("2: Leave, WHAT THE HECK IS WRONG WITH THEM!");
            Console.WriteLine("3: Cry.");
            Console.WriteLine("4: Get drunk.");

            Console.Write("Choice (1-4): ");
            string choice = Console.ReadLine()?.ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    EncounterBeets();
                    break;
                case "2":
                    CryAtDate();
                    break;
                case "3":
                    ExitBar();
                    break;
                case "4":
                    GetDrunk();
                    break;
                default:
                    RepeatFirstEncounter();
                    break;
            }
        }

        private static void EncounterBeets()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            DisplayTextWithBlankLine("You grab the extra spoon and chow down!");
            DisplayTextWithBlankLine(
                "You can't believe how considerate your date is to share.");
            DisplayTextWithBlankLine("You start to think this might be the one.");
            DisplayTextWithBlankLine("They begin to chat with you about their favorite music....");
            PromptContinue();
            SecondEncounter();
        }

        private static void ExitBar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            DisplayTextWithBlankLine("You decide this isn't for you and head for the door.");
            DisplayTextWithBlankLine(
                "Just as you exit, you run into someone who apologizes and offers you tickets to a show as an apology.");
            DisplayTextWithBlankLine("Do you take them and see where the night goes or do you continue on your way?");


            GameOver("Maybe romance just isn't for you...");
        }

        private static void CryAtDate()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            DisplayTextWithBlankLine("You can't hold back the tears. This was a bad idea.");
            DisplayTextWithBlankLine("Your date arrives and sees you crying. They decide to sit down and comfort you.");
            DisplayTextWithBlankLine("Turns out they have a good sense of humor about the whole situation.");
            PromptContinue();
            ThirdEncounter();
        }

        private static void GetDrunk()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            DisplayTextWithBlankLine("You throw caution to the wind and start knocking back shots.");
            DisplayTextWithBlankLine(
                "By the time your date arrives, you're dancing on the table to a song only you can hear.");
            DisplayTextWithBlankLine("Your date leaves in disgust, and you're asked to leave the restaurant.");
            GameOver("Well, that escalated quickly. Better luck next time!");
        }

        private static void SecondEncounter()
        {
            throw new NotImplementedException();
        }

        private static void ThirdEncounter()
        {
            throw new NotImplementedException();
        }

        private static void RepeatFirstEncounter()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("I don't understand that command....");
            PromptTryAgain();
            FirstEncounter();
        }

        private static void PromptTryAgain()
        {
            Console.WriteLine("Press 'Enter' to try again");
            Console.ReadLine();
        }

        private static void PromptContinue()
        {
            Console.WriteLine("Press 'ENTER' to continue.");
            Console.ReadLine();
        }

        private static void GameOver(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.WriteLine("\nGAME OVER");
            Console.WriteLine("\nPress 'Enter' to exit.");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}