namespace conditons_switch_case_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Enter a Number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1)
            {
                Console.WriteLine($"Your Number is positive {number}");
            }

            else if (number <= -1)
            {
                Console.WriteLine($"Your Number is negative {number} " );
            }

            else
            {
                Console.WriteLine("Your number is Zero");
            }

            // Short hand condition


            Console.WriteLine("Enter a Username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Enter a Password");
            string password = Console.ReadLine();

            string output = username == "admin" && password == "6969" ? "Login Succesfully. Welcome admin " : "invalid username or password";

            Console.WriteLine(output);



            //Switch Case

            Console.WriteLine("__Calculator__");

            Console.WriteLine("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter any one operator (+  -  *  /) ");
            string opt = Console.ReadLine();

            switch (opt)
            {
                case "+":
                    Console.WriteLine($"Add : {num1 + num2}");
                    break;

                case "-":
                    Console.WriteLine($"Subtract : {num1 - num2}");
                    break;

                case "*":
                    Console.WriteLine($"multiply : {num1 * num2}");
                    break;

                case "/":
                    if (num1 == 0 && num2 == 0)
                    {
                        Console.WriteLine("Result is Undefined");
                    }
                    else if (num1 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    else if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    else
                    {
                        Console.WriteLine($"Divide : {num1 / num2}");
                    }
                    break;
            }


        }
    }
}
