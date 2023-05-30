using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {

        public double GetFirstNumber()
        {
            Messages.FirstNumberMessage();
            double firstNumber = 0;

            bool isDouble = double.TryParse(Console.ReadLine(), out firstNumber);

            if (isDouble)
            {
                return firstNumber;
            }
            else
            {
                Messages.WrongEntryMessage();
                return GetFirstNumber();
            }
        }

        public double GetSecondNumber()
        {
            Messages.SecondNumberMessage();
            double secondNumber = 0;

            bool isDouble = double.TryParse(Console.ReadLine(), out secondNumber);

            if (isDouble)
            {
                return secondNumber;
            }
            else
            {
                Messages.WrongEntryMessage();
                return GetSecondNumber();
            }
        }

        public char GetOperation()
        {
            Messages.OperationMessage();
            char operation = 'X';

            bool isChar = char.TryParse(Console.ReadLine(), out operation);

            if (isChar)
            {
                if (operation == '+' || operation == '-' || operation == '*' || operation == '/' || operation == '%')
                {
                    return operation;
                }
                else
                {
                    Messages.WrongOperationMessage();
                    return GetOperation();
                }
            }
            else
            {
                Messages.WrongOperationMessage();
                return GetOperation();
            }
        }

        public double Calculation(double firstNumber, double secondNumber, char operation)
        {
            if (secondNumber == 0 && (operation == '/' || operation == '%'))
            {
                Messages.DivideByZeroMessage();
                secondNumber = GetSecondNumber();
                return Calculation(firstNumber, secondNumber, operation);
            }
            else if (operation == '+')
            {
                return firstNumber + secondNumber;
            }
            else if (operation == '-')
            {
                return firstNumber - secondNumber;
            }
            else if (operation == '*')
            {
                return firstNumber * secondNumber;
            }
            else if( operation == '/')
            {
                return firstNumber / secondNumber;
            }
            else
            {
                return firstNumber % secondNumber;
            }
        }

        public void ShowResult(double result)
        {
            Console.WriteLine("The result of this calculation is " + result);
        }
    }
}
