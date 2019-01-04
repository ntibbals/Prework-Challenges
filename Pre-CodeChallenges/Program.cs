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
            Console.WriteLine("2) Leap Year Calculator");
            Console.WriteLine("3) Perfect Sequence");
            Console.WriteLine("4) Sum of Rows");
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
                PerfectSequence();
                return true;
            }
            else if (result == "4")
            {
                SumOfRows();
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
            Console.Clear();
            Console.WriteLine("Challenge 2: Leap Year Calculator");

            Console.WriteLine("What year would you like to look into being a Leap Year?");
            string result = Console.ReadLine();
            bool userInput = Int32.TryParse(result, out int number);

            if (number % 400 == 0)
            {
                Console.WriteLine("Yes, {0} is in fact a Leap Year!", number);
                Console.ReadLine();
            }
            else if (number % 100 == 0)
            {
                Console.WriteLine("Sorry, {0} is NOT a Leap Year.", number);
                Console.ReadLine();
            }
            else if (number % 4 == 0)
            {
                Console.WriteLine("Yes, {0} is in fact a Leap Year!", number);
                Console.ReadLine();
            }
            else
                Console.WriteLine("Sorry, {0} is NOT a Leap Year.", number);
            Console.ReadLine();
        }

        private static void PerfectSequence()
        {
            Console.Clear();
            Console.WriteLine("Challenge 3: Perfect Sequence");

            Console.WriteLine("Input a sequence of 3 numbers below. After each single entry hit enter. ");
            int sum = 0;
            int multi = 1;

            int[] sequenceArray = new int[3];
            for (int i = 0; i < 3; i++)
            {
                sequenceArray[i] = int.Parse(Console.ReadLine());
            }



            for (int i = 0; i < sequenceArray.Length; i++)
            {
                sum += sequenceArray[i];
                multi *= sequenceArray[i];
            }
            Console.WriteLine($"The sum of your sequence is {sum} and the product is {multi}");
            if (sum < 0)
            {
                Console.WriteLine("No, this is not a perfect sequence.");
                Console.ReadLine();
            }
            else if (sum == multi)
            {
                Console.WriteLine("Yes, this is a perfect sequence!");
                Console.ReadLine();
            }


            else
            {
                Console.WriteLine("No, this is not a perfect sequence.");
                Console.ReadLine();
            }

        }
        private static void SumOfRows()
        {
            Console.Clear();
            Console.WriteLine("Challenge 4: Sum of Rows");

            Console.WriteLine("Please specifiy a matrix by giving the rows and columns of potential mulitdimensional array into the console below: ");
            Console.WriteLine("Rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Columns: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] myArray = new int[rows, columns];
            Random myRandom = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    myArray[i, j] = myRandom.Next(-100, 100);
                }
            }

            Console.WriteLine("Your matrix is: ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{String.Join(", ", myArray[i, j])}, ");
                }
                Console.Write("} ");
            }

            int[] sumArray = new int[myArray.GetLength(0)];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    sum += myArray[i, j];
                }
                sumArray[i] = sum;
            }

            Console.WriteLine();
            Console.WriteLine($"The sum of each row in your matrix is: [{String.Join(", ", sumArray)}]");
            Console.ReadLine();
        }

    }
}
