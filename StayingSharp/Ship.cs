using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StayingSharp
{
    class Ship
    {
        public static long EfficientShipping(List<long> boxes, List<long> unitsPerBox, long truckSize)
        {
            // Write your code here

            long maxVal;
            int indexBoxesAtMax;
            long numberBoxesAtMax;
            long totalUnits = 0;
            long boxesAdded = 0;

            for (long i = truckSize; i > 0; i -= boxesAdded)
            {
                if(unitsPerBox.Count == 0)
                {
                    return totalUnits;
                }

                maxVal = unitsPerBox.Max();

                indexBoxesAtMax = unitsPerBox.IndexOf(maxVal);
                numberBoxesAtMax = boxes[indexBoxesAtMax];

                if (numberBoxesAtMax <= i)
                {
                    boxesAdded = numberBoxesAtMax;
                    totalUnits += (maxVal * numberBoxesAtMax);
                    unitsPerBox.Remove(maxVal);
                    boxes.Remove(numberBoxesAtMax);
                }
                else
                {
                    totalUnits += (maxVal * i);
                    boxesAdded = i;
                    //this will only be executed in the last loop
                }
            }

            return totalUnits;
        }
    }
}

