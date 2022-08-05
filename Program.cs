using System;

namespace HOME3
{
    class Program
    {
        static bool Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (x <= y)
            {               
                sum = sum +x;
                x++;
            }
            Console.WriteLine(x);
        }
    }
}
