/* 
 * PROBLEM:
 * Write a program that reads from the console a sequence of positive integer numbers.
 * The sequence ends when empty line is entered. Calculate and print the sum and the 
 * average of the sequence. Keep the sequence in List<int>. 
 */

using System;
using System.Collections.Generic;

namespace ConsoleTasks.Assignments.A2
{
    class Driver
    {
        public Driver()
        {
            var inputs = new List<int>();
            string input;
            do
            {
                input = Console.ReadLine();
                try
                {
                    inputs.Add(int.Parse(input));
                } 
                catch (FormatException ex)
                {
                    if (input != "")
                        Console.WriteLine("Please enter a valid numeric value!");
                }
            } while (input != "");
            Console.Write("Input Array: [");

            int sum = 0;

            foreach (var i in inputs)
            {
                Console.Write(" " + i);
                sum += i;
            }
            Console.WriteLine(" ]\nSum: " + sum);
            Console.Write("Average: " + (sum / inputs.Count));

            Console.ReadKey();
        }
    }
}
