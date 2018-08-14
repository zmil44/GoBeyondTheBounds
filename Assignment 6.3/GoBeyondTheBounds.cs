/*Zachary Miller
 * 12/11/2017
 * assignment 6.3
 * The purpose of this program is to make an array of 5 numbers and print those numbers and then attempt to access the 6th number and go out of bounds and catch the exception
 * GoBeyondTheBounds.cs
 * Bellevue University
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._3
{
    class GoBeyondTheBounds
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            fillArray(numbers);
            display(numbers);
        }

        public static void fillArray(int[] numbers)
        {
            Random rand = new Random();
            for(int i=0;i<numbers.Length;i++)
            {
                numbers[i] = rand.Next(1, 50000);
            }

        }

        public static void display(int[] numbers)
        {
            try
            {
                for(int i =0;i<=10;i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Now you've gone beyond the bounds of the array");

            }
            Console.ReadLine();
        }
    }
}
