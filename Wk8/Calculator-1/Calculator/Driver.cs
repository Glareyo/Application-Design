
namespace CalculatorNS
{
    public class Driver
    {
        private static Calculator calculator = new Calculator();

        static bool isRunning = true;

        private static void Run()
        {
            Console.WriteLine("Select an option");
            Console.WriteLine("1. Run Calculator");
            Console.WriteLine("2. Exit");

            string input = Console.ReadLine();
            int option;
            bool success = int.TryParse(input,out option);
           
            if(success)
            {
                switch (option)
                {
                    case 1: RunCalculator();    break;
                    case 2: isRunning = false;  break;
                }
            }            
        }

        private static void RunCalculator()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");

            string input = Console.ReadLine();
            int option;
            bool success = int.TryParse(input, out option);

            if (success)
            {
                switch (option)
                {
                    case 1: calculator.SetOperation(Operation.Add); break;
                    case 2: calculator.SetOperation(Operation.Subtract); break;
                    case 3: calculator.SetOperation(Operation.Multiply); break;
                    case 4: calculator.SetOperation(Operation.Divide); break;
                    case 5: return;
                    default: RunCalculator(); return;
                }
            }
            else
            {
                RunCalculator();
            }

            do
            {
                Console.WriteLine("What is the first number?");
            } while (GetInput() == false);

            do
            {
                Console.WriteLine("What is the second number?");
            } while (GetInput() == false);

            float result;
            if(calculator.ComputeInputs(out result))
            {
                Console.WriteLine("The result is: {0}", result);
            }
            else
            {
                Console.WriteLine("An error has occured. Please try again.");
            }

            calculator.Clear();            
        }

        private static bool GetInput()
        {            
            string input = Console.ReadLine();
            float number;
            bool success = float.TryParse(input, out number);

            if (success)
            {
                calculator.AddInput(number);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main()
        {
            while(isRunning)
            {
                Run();
            }
        }
    }
}
