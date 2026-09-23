namespace Loops_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            for (int i = 1; i <= 10; i++) {

                Console.WriteLine($"For Loop: {i}");
            }

            //infinite Loop

            //for (int i = 1; i <= 10; i--)
            //{

            //    Console.WriteLine($"For Loop: {i}");
            //}

            //while (true)
            //{
            //    Console.WriteLine("Enter a NUmber: ");
            //    Console.ReadLine();
            //}

            int k = 1;

            do {
                Console.WriteLine($"Do while Loop {k}");
                k++;
            }
            
            while (k >= 5);

            for (int i = 1; i <+ 20; i++) {
            
                Console.WriteLine($"Iteration: {i}");

                if (i == 6) {

                    break;
                }

                while (true) {
                    Console.WriteLine("Enter a number: ");
                    int number = Convert.ToInt32 (Console.ReadLine());

                    if (number > 10)
                    {
                        Console.WriteLine($"Wrong number  was added. loop has been stopped {number}");
                        break;
                    }

                    if (number < 0)
                    {
                        Console.WriteLine($"Wrong number  was added. loop has been stopped {number}");
                        break;
                    }

                    Console.WriteLine($"You add {number}");

                    for (int j = 1; j <= 20; j++)
                    {
                        if (j == 5 || j == 10 || j == 15 || j == 18) {
                            continue;
                        }

                        Console.WriteLine($"iteration: {j}");
                    }
                }

            }

        }



    }
}
