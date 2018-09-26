using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> n = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int cntCurrSeq = 0;
            int startCurrSeq = 0;
            int cntMaxSeq = 0;
            int startMaxSeq = 0;

            for (int i = 1; i < n.Count; i++)
            {
                if (n[i] - n[i - 1] >= 1)
                {
                    cntCurrSeq++;
                    startCurrSeq = i - cntCurrSeq;

                    if (cntCurrSeq > cntMaxSeq)
                    {
                        cntMaxSeq = cntCurrSeq;
                        startMaxSeq = startCurrSeq;
                    }
                }
                else
                {
                    cntCurrSeq = 0;
                }
            }
            for (int iWrite = startMaxSeq; iWrite <= (startMaxSeq + cntMaxSeq); iWrite++)
            {
                Console.Write(n[iWrite] + " ");
            }
            Console.WriteLine();
        }
    }
}
