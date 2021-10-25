using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the first number: ");
                string userStringFirstNum = Console.ReadLine();
                //check if user entered a num
                float userFirstNum = IsNumber(userStringFirstNum);
                Console.WriteLine("Enter the second number: ");
                string userStringSecondNum = Console.ReadLine();
                //check if user netered a number
                float userSecondNum = IsNumber(userStringSecondNum);

                Console.WriteLine("Hello User!\nWelcome to a console based calculator");
                Console.WriteLine("Enter the number for the operation you wish you complete: ");
                Console.WriteLine("\t1 for addition");
                Console.WriteLine("\t2 for subtraction");
                Console.WriteLine("\t3 for multiplication");
                Console.WriteLine("\t4 for division");
                Console.WriteLine("\t5 to quit and exit program");
                char userInput = char.Parse(Console.ReadLine());

                if (userInput == '5')
                {
                    Console.WriteLine("Exiting program. Good Bye!");
                    break;
                }

                switch (userInput)
                {
                    case '1':
                        Add(userFirstNum, userSecondNum);
                        break;
                    case '2':
                        Subtract(userFirstNum, userSecondNum);
                        break;
                    case '3':
                        Mutliply(userFirstNum, userSecondNum);
                        break;
                    case '4':
                        Divide(userFirstNum, userSecondNum);

                        break;
                    default:
                        Console.WriteLine("Error. Did not understand your input.\nPlease try again");
                        continue;
                }
                Console.WriteLine("Would you like to continue.\nEnter Y for yes or N for no.");
                string userChoice = Console.ReadLine();
                char UserCharChoice = char.Parse(userChoice.ToUpper());
                if (UserCharChoice == 'N')
                {
                    Console.WriteLine("Have a great day. Good Bye!");
                    break;
                }
                else if (UserCharChoice == 'Y')
                {
                    continue;
                }

            }
        }
        static bool CheckNumber(string userNum)
        {
            for (int i = 0; i < userNum.Length; i++)
                if (char.IsDigit(userNum[i]) == false)
                    return false;

            return true;
        }
        public static float IsNumber(string userNum)
        {
            float num;
            while (!float.TryParse(userNum, out num))
            {
                if (CheckNumber(userNum))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a number. Please try again\nEnter a number: ");
                    userNum = Console.ReadLine();
                    IsNumber(userNum);
                    break;
                }
            }
            return num;
        }

        public static void Add(float num1, float num2)
        {
            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
        }
        public static void Subtract(float num1, float num2)
        {
            Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
        }
        public static void Mutliply(float num1, float num2)
        {
            Console.WriteLine("{0} x {1} = {2}", num1, num2, (num1 * num2));
        }
        public static void Divide(float num1, float num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("{0} / {1} = UNDEFINED\n", num1, num2);
                Console.WriteLine("Error, Divide by 0\n");
            }
            else
            {
                Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
            }
        }
    }
}