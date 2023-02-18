class Calculator
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN;

        switch (op)
        {
            case "a":
                result = num1 + num2;
                break;

            case "s":
                result = num1 - num2;
                break;

            case "d":
                if (num2 != 0)
                {
                    result = num2 / num1;
                }
                break;

            case "m":
                result = num1 * num2;
                break;
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("C# caluclator app");
        Console.WriteLine("------------------");

        while (!endApp)
        {
            string numInput1 = "";
            string numInput2 = "";
            double result = 0;

            Console.Write("Type a number, and then press enter: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("This is not a valid input. Please type an integer ");
                numInput1 = Console.ReadLine();
            }

            Console.Write("Type another number and then press enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("This is not a valid input. Please type an integer ");
                numInput2 = Console.ReadLine();
            }

            Console.WriteLine("Choose an operator from this list");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option?");

            string op = Console.ReadLine();

            try
            {
                result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation will result in a mathmatical error");
                }
                else Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred!");
            }

            Console.WriteLine("------------------------\n");

            Console.WriteLine("Press 'n' to close the application");
            if (Console.ReadLine() == "n") endApp = true;
            Console.WriteLine("\n");
        }
    }
}