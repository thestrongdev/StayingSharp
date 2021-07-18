using System;
using System.Collections.Generic;
using System.Text;

namespace StayingSharp
{
    class ThreeZero
    {
        public static int[][] Triplet(int[] arr)
        {
            //given an array, output an array of all groups of three numbers from that array that add to zero

            if (arr.Length < 3)
            {
                Console.WriteLine("Not valid number of digits");
            }

            //(1) need all combinations of 3 numbers for max length of array? n choose 3
            //create a recursive factorial function to use here...
            var maxCombin = Factorial(arr.Length) / (Factorial(3) * Factorial(arr.Length - 3));

            //given array of length n!, how do we do this?

            var zeroThrees = new int[maxCombin][];

            //Logic to find all combos of 3 numbers that sum to zero




            return zeroThrees;
        }

        public static int Factorial(int x)
        {
            if (x <= 0)
            {
                return 1;
            }

            return Factorial(x - 1) * x;
        }
    }
}
