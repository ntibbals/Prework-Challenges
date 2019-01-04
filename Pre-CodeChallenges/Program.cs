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

        // ********** CHALLENGE 1 ******************
        private static void ArrayMax()
        {
            Console.Clear();
            Console.WriteLine("Challenge 1: Array Max Result");

            Random myRandom = new Random(); //random int for array
            int[] randomArray = new int[5]; //initialize array that includes an index of 5 int
            for (int i = 0; i < 5; i++) //assign 5 random numbers to each index in array
            {
                randomArray[i] = myRandom.Next(1, 11);
            }
            int score = 0;


            Console.WriteLine("Select one of the following numbers: ");

            for (int i = 0; i < randomArray.Length; i++) //for loop to display each random number
            {
                Console.Write($" {randomArray[i]}");
            }
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", randomArray[0], randomArray[1], randomArray[2], randomArray[3], randomArray[4]);
            Console.WriteLine();
            Console.Write("Your selection: ");
            string result = Console.ReadLine();
            bool userInput = Int32.TryParse(result, out int number); //parse input string into an integer but could also utilize int.Parse(x)
            for (int i = 0; i < randomArray.Length; i++) //for loop to run through array and calculate score
            {
                if (number == randomArray[i]) //conditional statement to check if selected number is in array, if so calculate based on number of times in array
                    score += randomArray[i];

            }
            Console.WriteLine("Your score is {0}!", score);
            Console.ReadLine();

        }

        // ********* CHALLENGE 2 *************
        private static void LeapYearCalc()
        {
            Console.Clear();
            Console.WriteLine("Challenge 2: Leap Year Calculator");

            Console.WriteLine("What year would you like to look into being a Leap Year?");
            string result = Console.ReadLine();
            bool userInput = Int32.TryParse(result, out int number); //parse input from end user into integer

            //conditional statements to determine if input is a leap year
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

        //************* CHALLENGE 3 **********************
        private static void PerfectSequence()
        {
            Console.Clear();
            Console.WriteLine("Challenge 3: Perfect Sequence");

            Console.WriteLine("Input a sequence of 3 numbers below. After each single entry hit enter. ");
            int sum = 0; //placeholder for sum calculation
            int multi = 1; //placeholder for product calculation

            int[] sequenceArray = new int[3]; //initialize array with a length of 3
            for (int i = 0; i < 3; i++) //for loop to assign each value in array based on user input
            {
                sequenceArray[i] = int.Parse(Console.ReadLine()); //parse each user input into integer and assign to array position i
            }

            for (int i = 0; i < sequenceArray.Length; i++) //for loop to calculate if user input sequence array is perfect based on sum and product
            {
                sum += sequenceArray[i];
                multi *= sequenceArray[i];
            }
            Console.WriteLine($"The sum of your sequence is {sum} and the product is {multi}");
            //conditional statements below to dipslay validation
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

        //*********** CHALLENGE 4 *****************
        private static void SumOfRows()
        {
            Console.Clear();
            Console.WriteLine("Challenge 4: Sum of Rows");

            Console.WriteLine("Please specifiy a matrix by giving the rows and columns of potential mulitdimensional array into the console below: ");
            Console.WriteLine("Rows: ");
            int rows = int.Parse(Console.ReadLine()); //parse user input into integer for 1st dimension in array
            Console.WriteLine("Columns: ");
            int columns = int.Parse(Console.ReadLine()); //parse user input into integer for 2nd dimension in array

            int[,] myArray = new int[rows, columns]; //initialize multi-dimensional array based on user input for rows/columns
            Random myRandom = new Random();
            for (int i = 0; i < rows; i++) //utilize a nested for loop to take a random number and assign to each index first based on rows/then column
            {
                for (int j = 0; j < columns; j++)
                {
                    myArray[i, j] = myRandom.Next(-100, 100);
                }
            }

            Console.WriteLine("Your matrix is: ");
            for (int i = 0; i < rows; i++) //utilize a nested for loop to display given matrix to end user
            {
                Console.Write("{ ");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{myArray[i, j]}, "); //display each position in array
                }
                Console.Write("} ");
            }

            int[] sumArray = new int[myArray.GetLength(0)]; // create another array to hold sum of each row based on .GetLength of array

            for (int i = 0; i < myArray.GetLength(0); i++) //nested for loop for sum calculations to run through each position based on .GetLength
            {
                int sum = 0; //placeholder for sum of each row
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    sum += myArray[i, j]; //calculates sum of each position and assign to placeholder
                }
                sumArray[i] = sum; //assign sum calculated to each position in sumArray
            }

            Console.WriteLine();
            Console.WriteLine($"The sum of each row in your matrix is: [{String.Join(", ", sumArray)}]");
            Console.ReadLine();
        }

    }
}
