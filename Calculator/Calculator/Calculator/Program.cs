using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Messages.WelcomeMessage();
            Calculate();
        }

        private static void Calculate()
        {
            bool continued = true;


            while (continued)
            {
                Calculator calculator = new Calculator();

                double result = calculator.Calculation(calculator.GetFirstNumber(), calculator.GetSecondNumber(), calculator.GetOperation());

                calculator.ShowResult(result);

                Messages.ContinueMessage();

                bool continuation = Continue();
                
                if (!continuation)
                {
                    Messages.GoodByeMessage();
                    continued = false;
                }
            }
           
        }

        private static bool Continue()
        {
            char continuationAnswer = 'X';

            bool continued = char.TryParse(Console.ReadLine(), out continuationAnswer);

            if (continued)
            {
                if (continuationAnswer == 'Y' || continuationAnswer == 'y')
                {
                    return continued;
                }
                else if(continuationAnswer == 'N' || continuationAnswer == 'n')
                {
                    return !continued;
                }
                else
                {
                    Messages.ContinuationErrorMessage();
                    return Continue();
                }
            }
            else
            {
                Messages.ContinuationErrorMessage();
                return Continue();
            }
        }
    }
}