using System;
using System.Collections.Generic;
using System.Linq;

class SortedSubsetSums //KatyaMarincheva
{
    static List<List<int>> subsets = new List<List<int>>();
    static int[] numbs;
    static int n;
    static bool solution = false;

    static void Main()
    {
        /* Write a program that reads from the console a number N and an array of integers given on a single line. 
        Your task is to find all subsets within the array which have a sum equal to N and print them on the console
        (the order of printing is not important). Find only the unique subsets by filtering out repeating numbers first.
        In case there aren't any subsets with the desired sum, print "No matching subsets."
        */
        n = int.Parse(Console.ReadLine());
        numbs = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();
        Array.Sort(numbs);
        //numbers = new int[] { 1, 2, 3, 4 };
        List<int> subset = new List<int>();
        MakeSubset(0, subset);
        var sorted = subsets.OrderBy(x => x.Count);
        foreach (var item in sorted)
        {
            Console.WriteLine(" {0} = {1}", string.Join(" + ", item), n);
        }
        if (!solution)// if no sum matches N
            Console.WriteLine("No matching subsets.");
    }

    static void MakeSubset(int index, List<int> subset)
    {
        if (subset.Sum() == n && subset.Count > 0) // if subset sum = N, print it on the console
        {
            subsets.Add(new List<int>(subset));
            solution = true; // set solution to true, and we will not be printing that there is no solution
        }
        //Console.WriteLine(string.Join(" ", subset));
        for (int i = index; i < numbs.Length; i++)
        {
            subset.Add(numbs[i]);
            MakeSubset(i + 1, subset); // call MakeSubset recursively, every time starting from the previous index + 1
            subset.RemoveAt(subset.Count - 1); // remove last element
        }
    }
}/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string [] numbs = input.Split(' ');
            int[] numbers = new int[numbs.Length];
            for (int i = 0; i <numbs.Length; i++)
            {
                numbers[i] = Convert.ToInt32(numbs[i]);
            }
           //Console.WriteLine(String.Join(" ",numbers));

        }
    }
} */
