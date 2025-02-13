namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vyvedi chislo: ");
            int number = int.Parse(Console.ReadLine());

            int sum = SumOfDigits(number);
            Console.WriteLine($"Сумата на цифрите е: {sum}");
        }
        static int SumOfDigits(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n % 10 + SumOfDigits(n / 10);
        }
    }
}
