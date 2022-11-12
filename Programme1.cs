using System;
using System.Collections.Generic;



namespace ConsoleApp1
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre un nombre");
            int nombre = int.Parse(Console.ReadLine());
            int r = 0;
            int g = 1;
            Stack<string> ch = new Stack<string>();
            do
            {
                r = nombre % 16;
                nombre = nombre / 16;
                if (r == 10)
                {
                    ch.Push("A");
                }
                else if (r == 11)
                {
                    ch.Push("B");
                }
                else if (r == 12)
                {
                    ch.Push("C");
                }
                else if (r == 13)
                {
                    ch.Push("D");
                }
                else if (r == 14)
                {
                    ch.Push("E");
                }
                else if (r == 15)
                {
                    ch.Push("F");
                }
                else
                {
                    ch.Push(Convert.ToString(r));
                }


            }
            while (nombre % 16 != 0);

            Console.WriteLine("Code hexadecimal : ");
            foreach(var ele in ch)
            {
                Console.WriteLine(ele); 
            }
}
    }
}
