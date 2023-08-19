namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Threes()
        {
            for(int k = 3; k <= 999; k+=3)
            {
                Console.WriteLine(k);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool IsEqual(int a, int b)
        {
            if (a == b) 
            {
                return true;
            }
                return false;
        }
        //Write a method to check whether a given number is even or odd
        public static void IsOdd()
        {
            int i;
            Console.Write("Please Enter a Number you want to check : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Number is an Even Number");
            }
            else
            {
                Console.WriteLine("Number is an Odd Number");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void IsPositive()
        {
            int a;
            Console.Write("Please Enter a Number you want to check : ");
            a = int.Parse(Console.ReadLine());
            if (a >= 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is Negative");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanVote()
        {
            int b;
            Console.Write("Please Enter the age of the candidate : ");
            b = int.Parse(Console.ReadLine());
            if (b >= 18)
            {
                Console.WriteLine("Candidate can vote");
            }
            else
            {
                Console.WriteLine("Candidate can not vote");
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void Range()
        {
            int b;
            Console.WriteLine("Please Enter a number to check : ");
            b = int.Parse(Console.ReadLine());
            if (b >= -10 && b <= 10)
            {
                Console.WriteLine("Number is in the range of -10 to 10");
            }
            else
            {
                Console.WriteLine("Number is NOT the range of -10 to 10");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable()
        {
            int j;
            int k;
            Console.WriteLine("*****Multiplication Table*****");
            Console.WriteLine("Please enter a number to calculate: ");
            k = int.Parse(Console.ReadLine());
            for (j = 1; j <= 12; j++)
            {
                Console.WriteLine("{0} X {1} = {2} \n", k, j, k * j);
            }
        }
        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintThousand();
            Threes();
            Console.WriteLine(IsEqual(2,8)); 
            IsOdd();
            IsPositive();
            CanVote();
            Range();
            MultiplicationTable();
        }
    }
}
