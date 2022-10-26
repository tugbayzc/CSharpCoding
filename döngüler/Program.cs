using System;

namespace donguler 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(a+"x"+i+"="+a*i);

            }

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if(n<=100)
                   Console.WriteLine(new String(' ', n - i) + new String('#', i));
            }
        }
    }
}
