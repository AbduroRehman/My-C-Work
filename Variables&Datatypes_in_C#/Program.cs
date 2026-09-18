namespace mujahidden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome to C#");
            Console.WriteLine(".Net FrameWork");
            Console.WriteLine("Input And Output");

            // Variables
            // datatype variable name = value

            int integer = 1234;
            string StrintText = "Danish bhoi";
            double doubleNo = 12;
            decimal decimalNo = 10;
            float floatNo = 50F;
            bool boolValue = true;
            Char CHarValue = 'A';

            //Arrays
            String[] arrayString = {"A" , "B" , "C" };
            int[] array_int = {1,2,3,4,5,6,7,8 };
            object[] array_object = { 1, "mujahideen" , false , 12.12};

            //Concatination
            Console.WriteLine("Integer:"+integer);
            Console.WriteLine($"Integer:{integer} decimal: {decimalNo} double: {doubleNo} float: {floatNo} bool:{boolValue} char:{CHarValue} ArrayString: {arrayString[0]}");

            Console.WriteLine("\t-------\"MARKSHEET\n-------");
            // Console.ReadLine(); Gets users input with that

            Console.WriteLine("Enter Student Name: ");
            string stdname = Console.ReadLine();

            Console.WriteLine("Enter Maths Number: ");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter English Number: ");
            int eng = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Computer Number: ");
            int Computer = Convert.ToInt32(Console.ReadLine());

            int total = maths + eng + Computer;

            double Percentage = total / 300.0 * 100;

            Console.WriteLine($"Student Name: {stdname} Maths: {maths} English: {eng} Computer: {Computer} Total: {total} Percentage: {Percentage}%");




        }
    }
}
