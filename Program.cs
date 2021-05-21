using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace ConsoleApp1
{
    class Program
    {
        public static int MinimumAbsoluteDifference(List<int> arr)
        {
            List<int> getValue = new List<int>();
            int minValue = 0, sayac = 0, indis = 0;
            while (true)
            {
                if (arr.Count == 1) break;
                sayac++;
                getValue.Add(Math.Abs(arr[indis] - arr[sayac]));
                if (sayac + 1 == arr.Count)
                {
                    sayac = 0;
                    arr.RemoveAt(indis);
                }
            }
            minValue = getValue.Min();
            return minValue;
        }
        static void Main(string[] args)
        {
            Console.Write("Input : ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Console.Write("Numbers : ");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = MinimumAbsoluteDifference(arr);
            Console.WriteLine("Expected Output : " + result);
            Console.ReadLine();
        }
    }
}
