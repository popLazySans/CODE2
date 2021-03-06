using System;

namespace ASS_ignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
           

            if (x < 0)
            {
                Console.WriteLine("Invalid mouse position");
            }
            else if (mode == "time")
            {
                y = Math.Pow(1.0 - x, 2.0);
                Console.WriteLine("{0}, {1}",x,y);
            }
            else if(mode == "price")
            {
                if (y < 1 && x < 1)
                {
                    x = -Math.Sqrt(y) + 1.0;
                }
                else
                {
                    x = Math.Sqrt(y) + 1.0;
                }
                if (y < 0  )
                {
                    Console.WriteLine("Don't have position");
                }
                else
                {
                    Console.WriteLine("{0}, {1}", x, y);
                }
            }
            else
            {
                Console.WriteLine("Invalid mode");
            }
           
        }
    }
}
