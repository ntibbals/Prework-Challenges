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
            string result = Console.ReadLine();
            if (result == "1")
            {
                
                return true;
            }
            else if (result == "2")
            {
               
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
    }
}
