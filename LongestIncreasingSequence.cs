﻿using System;
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
                    //Console.Write(String.Join(" ", digits));
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