namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Yigindi :");
            var number = Convert.ToInt32(Console.ReadLine());
            var numberOne = number % 10;
            var numberTens = number / 10 % 10;
            var numberHunders = number / 100 % 10;
            var numberThousand = number / 1000;
            var result=numberOne + numberTens + numberHunders+numberThousand;  
            Console.WriteLine(result);
        }
    }
}
