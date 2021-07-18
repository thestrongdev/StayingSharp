using System;
using System.Collections.Generic;

namespace StayingSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //------------------------------------------------------
            //Test Factorial
            //------------------------------------------------------
            var factorialSix = ThreeZero.Factorial(6);
            Console.WriteLine(factorialSix);

            //------------------------------------------------------
            //Validate IP Addresses
            //------------------------------------------------------

            var testIps = new List<string>();
            testIps.Add("121.18.19.20");
            testIps.Add("0.12.12.34");
            testIps.Add("121.234.12.12");
            testIps.Add("23.45.12.56");
            testIps.Add("0.1.2.3");
            testIps.Add("2001:0db8:0000:0000:0000:ff00:42:8329");
            testIps.Add("2001:db8:0:0:0:ff00:42:8329");
            testIps.Add("2001:db8::ff00:42:8329");
            testIps.Add("0000:0000:0000:0000:0000:0000:0000:0001");
            testIps.Add("::1");
            testIps.Add("000.012.234.23");
            testIps.Add("666.666.23.23");
            testIps.Add(".213.123.23.32");
            testIps.Add("23.45.22.32.");
            testIps.Add("272:2624:235e:3bc2:c46d:682:5d46:638g");
            testIps.Add("1:22:333:4444");

            var results = IpValidation.validateIp(testIps);
            //first 5 should be IPv4, next 5 should be IPv6, last 6 should be neither

            foreach (string val in results)
            {
                Console.WriteLine(val);
            }

            //------------------------------------------------------
            //Three Zero Sum
            //------------------------------------------------------

            //------------------------------------------------------
            //Selling Products
            //------------------------------------------------------
            var n = new int[] { 1, 1, 5, 5 };
            var m = 2;

            var maxDeletes = SellingProducts.deleteProducts(n, m);
            //should be 2


            var o = new int[] {1, 2, 3, 1, 2, 2, 1};
            m = 3;
            maxDeletes = SellingProducts.deleteProducts(o, m);
            //should be 2

            //------------------------------------------------------
            //Efficient shipping
            //------------------------------------------------------

            //var boxes = new List<long>();
            //boxes.Add(4);
            //boxes.Add(6);
            //boxes.Add(5);
            //boxes.Add(2);
            //boxes.Add(7);

            //var units = new List<long>();
            //units.Add(46335);
            //units.Add(90039);
            //units.Add(24796);
            //units.Add(87808);
            //units.Add(17739);

            //var trucksize = 610563;

            //var totalUnits = Ship.EfficientShipping(boxes, units, trucksize);
            //Console.WriteLine(totalUnits);
            //answer should be 1149343

            //------------------------------------------------------
            //Unique loves
            //------------------------------------------------------

            //Console.WriteLine(Problems.UniqueLove(90, 88));

            //var DataStructPract = new NewQueue();

            //DataStructPract.Enqueue(2);
            //DataStructPract.Enqueue(3);
            //DataStructPract.Enqueue(4);
            //DataStructPract.Enqueue(5);

            //Console.WriteLine(DataStructPract.StackOne.Pop());

            //var queueVal = DataStructPract.Dequeue();

            //Console.WriteLine(queueVal);

            //var nextVal = DataStructPract.Dequeue();

            //Console.WriteLine(nextVal);


        }
    }
}
