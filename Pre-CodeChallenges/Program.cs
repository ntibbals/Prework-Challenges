using System;

namespace Pre_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Array Max Result");
            Console.WriteLine("1) Array Max Result");
            string result = Console.ReadLine();
            if (result == "1")
            {
                ArrayMax();
                return true;
            }
            else if (result == "2")
            {
                LeapYearCalc();
                return true;
            }
            else if (result == "3")
            {
              
                return true;
            }
            else if (result == "4")
            {
                return true;
            }
            else
            {
                return true;
            }
        }
        private static void ArrayMax()
        {
            Console.Clear();
            Console.WriteLine("Challenge 1: Array Max Result");

            int[] randomArray = new int[5];
            Random myRandom = new Random();
            for (int i = 0; i < 5; i++)
            {
                randomArray[i] = myRandom.Next(1, 11);
            }
            int score = 0;


            Console.WriteLine("Select one of the following numbers: ");
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", randomArray[0], randomArray[1], randomArray[2], randomArray[3], randomArray[4]);
            string result = Console.ReadLine();
            bool userInput = Int32.TryParse(result, out int number);
            for (int i = 0; i < randomArray.Length; i++)
            {
                if (number == randomArray[i])
                    score += randomArray[i];

            }
            Console.WriteLine("Your score is {0}!", score);
            Console.ReadLine();

        }
        private static void LeapYearCalc()
        {


        }
    }
}
