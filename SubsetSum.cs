using System;
using System.Collections.Generic;
using System.Linq;

class SortedSubsetSums
{
    static List<List<int>> subsets = new List<List<int>>();
    static int[] numbs;
    static int n;
    static bool result = false;

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
       
        List<int> subset = new List<int>();
        MakeSubset(0, subset);
        var sorted = subsets.OrderBy(x => x.Count);
        foreach (var item in sorted)
        {
            Console.WriteLine(" {0} = {1}", string.Join(" + ", item), n);
        }
        if (!result)// if no sum matches N
            Console.WriteLine("No matching subsets.");
    }

    static void MakeSubset(int index, List<int> subset)
    {
        if (subset.Sum() == n && subset.Count > 0) 
        {
            subsets.Add(new List<int>(subset));
            result = true; 
        }
        for (int i = index; i < numbs.Length; i++)
        {
            subset.Add(numbs[i]);
            MakeSubset(i + 1, subset); 
            subset.RemoveAt(subset.Count - 1);
        }
    }
}
