namespace Project2PerfectNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            int y = int.Parse(Console.ReadLine());
            printperfect(x, y);
            Console.ReadKey();
        }
        public static bool perfectcheck(int num)
        {
            int x = 1;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    x += i;
                }
            }
            if (num == x && num > 1)
            {
                return true;
            }
            return false;
        }
        public static void printperfect(int num1, int num2)
        {
            int o = num2 > num1 ? num2 : num1;//bigger
            int p = num2 > num1 ? num1 : num2;//smaller
            while (o >= p)
            {
                if (perfectcheck(p))
                {
                    Console.WriteLine(p);
                }
                ++p;
            }
        }
    }
}