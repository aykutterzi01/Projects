using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Messages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the calculator program!");
        }

        public static void FirstNumberMessage()
        {
            Console.WriteLine("Please enter the first number.");
        }

        public static void WrongEntryMessage()
        {
            Console.WriteLine("Please enter a valid number.");
        }

        public static void SecondNumberMessage()
        {
            Console.WriteLine("Please enter the second number.");
        }

        public static void WrongOperationMessage()
        {
            Console.WriteLine("Please enter a valid operation.");
        }

        public static void OperationMessage()
        {
            Console.WriteLine("Please enter an operation: +, -, *, /, % ");
        }

        public static void DivideByZeroMessage()
        {
            Console.WriteLine("Division by zero is not possible. Please enter a number other than 0.");
        }

        internal static void ContinueMessage()
        {
            Console.WriteLine("Would you like to make another calculation? (Y/N)");
        }

        internal static void ContinuationErrorMessage()
        {
            Console.WriteLine("Please enter a valid answer.");
        }

        internal static void GoodByeMessage()
        {
            Console.WriteLine("Thank you for using the calculator. See you later.");
        }
    }
}
