using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StayingSharp
{
    class Problems
    {
        public static int UniqueLove(int upper, int lower)
        {
            int length = upper - lower + 1;
            int[] unique = new int[length];
            int count = lower;

            //create array of numbers
            for (int i = 0; i <length; i++)
            {
                unique[i] = count;
                count += 1;
                Console.WriteLine(count);
            }

            int countUnique = 0;
            
            //now count the unique numbers.
            foreach (int num in unique)
            {
                char[] digits = num.ToString().ToCharArray();

                List<int> digitsList = new List<int>();

                for (int i = 0; i < digits.Length; i++)
                {
                    digitsList.Add((int)Char.GetNumericValue(digits[i]));
                }

                if (digitsList.Distinct().Count() == digits.Length)
                {
                    countUnique += 1;
                }
            }
            return countUnique;           
        }

        

    }
}
