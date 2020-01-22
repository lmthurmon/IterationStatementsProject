using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //list is another collection of items of a type 
            //with var List<int>numbers
            var numbers = new List<int>();
            var i = 0;
            //Create a List called "numbers"
            //Create a variable of type int with an initializer of 0



            // Create a do-while loop
            do //execute code while condition is still true
            {
                // Increment your variable by 1
                // Then add your variable to "numbers"
                i++;
                numbers.Add(i);
            }
            while (i < 100);
            // While your variable is less than 100



            // Create a while loop
            // While your variable is less than 200
            while (i < 200) //execute code until something changes
            {
                i++;
                numbers.Add(i);
                // Increment your variable by 1
                // Then add your variable to "numbers"
            }

            Console.WriteLine("Increase:");

            foreach (var Num in numbers) //do something for each item in list
            {
                Console.WriteLine(Num);
            }
            // Create a foreach loop
            // Write your variable to the console

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            // reads indicator then check condition, then runs code, then interator,repeat
            for (i = 199; i <= numbers.Count && i >= 0; --i)
            {
                Console.WriteLine(numbers [i]);
                // Write to the console "numbers" at index i
            }
            Console.WriteLine(numbers.Count);
        }
    }
}
