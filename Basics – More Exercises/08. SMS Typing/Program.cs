using System;
using System.Text;

namespace _08._SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder str = new StringBuilder(); 

            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());

                if(m == 2)
                {
                    str.Append("a");
                }
                else if(m == 22)
                {
                    str.Append("b");
                }
                else if(m == 222)
                {
                    str.Append("c");
                }
                else if(m == 3)
                {
                    str.Append("d");
                }
                else if(m == 33)
                {
                    str.Append("e");
                }
                else if(m == 333)
                {
                    str.Append("f");
                }
                else if(m == 4)
                {
                    str.Append("g");
                }
                else if(m == 44)
                {
                    str.Append("h");
                }
                else if(m == 444)
                {
                    str.Append("i");
                }
                else if(m == 5)
                {
                    str.Append("j");
                }
                else if(m == 55)
                {
                    str.Append("k");
                }
                else if(m == 555)
                {
                    str.Append("l");
                }
                else if(m == 6)
                {
                    str.Append("m");
                }
                else if(m == 66)
                {
                    str.Append("n");
                }
                else if(m == 666)
                {
                    str.Append("o");
                }
                else if(m == 7)
                {
                    str.Append("p");
                }
                else if(m == 77)
                {
                    str.Append("q");
                }
                else if(m == 777)
                {
                    str.Append("r");
                }
                else if(m == 7777)
                {
                    str.Append("s");
                }
                else if(m == 8)
                {
                    str.Append("t");
                }
                else if(m == 88)
                {
                    str.Append("u");
                }
                else if(m == 888)
                {
                    str.Append("v");
                }
                else if(m == 9)
                {
                    str.Append("w");
                }
                else if(m == 99)
                {
                    str.Append("x");
                }
                else if(m == 999)
                {
                    str.Append("y");
                }
                else if(m == 9999)
                {
                    str.Append("z");
                }
                else if(m == 0)
                {
                    str.Append(" ");
                }
            }

            Console.WriteLine(str);
        }
    }
}
