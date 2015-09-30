using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncrSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
       Write a program to find all increasing sequences inside an array of integers. 
       The integers are given on a single line, separated by a space. Print the sequences
       in the order of their appearance in the input array, each at a single line. Separate 
       the sequence elements by a space. Find also the longest increasing sequence and print 
       it at the last line. If several sequences have the same longest length, print the left-most of them. 

    */
            List<int> digits = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 1;
            int maxLength = 1;
            int end = 0;
            for (int i = 0; i < digits.Count-1; i++)
            {
                if (digits[i] < digits[i + 1])
                {
                    count++;
                    Console.Write(digits[i] + " ");
                }
                else
                {
                    count = 1;
                    Console.WriteLine(digits[i]+ " ");
                }
                if (count>maxLength)
                {
                    maxLength = count;
                    end = i+1;
                }

            }
            Console.Write(digits.Last());
            Console.WriteLine();
            Console.Write("Longest: ");
            for (int j= end-maxLength+1;j<= end;j++)
            {
                Console.Write(digits[j]+ " ");
            }

        }
    }
}
