using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = System.Convert.ToInt32(Console.ReadLine());
            //ArrayList[][] rings = new ArrayList[limit-3][];
            ArrayList testRing = new ArrayList();

            int modN = limit;
            //for (int modN = 3; modN < limit; modN++)
            //{
                //rings[modN - 3] = new ArrayList[modN - 1];
                //for (int a = 1; a < modN; a++)
                //{
                int a = System.Convert.ToInt32(Console.ReadLine());
                    //rings[modN - 3][a - 1] = new ArrayList();
                    //rings[modN - 3][a-1].Add(modN);
                    testRing.Add(modN);
                    testRing.Add(a);
                    ////rings[modN - 3][a-1].Add(1);
                    //rings[modN - 3][a-1].Add(a);
                    int rem = (a * a) % modN;
                    while(!testRing.Contains(rem) && rem != 0)//rings[modN - 3][a -1].Contains(rem) && rem != 0)
                    {
                        //rings[modN - 3][a - 1].Add(rem);
                        testRing.Add(rem);
                        rem = (rem * a) % modN;
                        //Console.Out.WriteLine(rem + " ");
                    }
                    //rings[modN - 3][a - 1].Add(rem);
                //}
            //}

            //foreach(Array b in rings)
            //{
            //    foreach (ArrayList ca in rings[modN - 3][a-1])
            //    {
            //        if (true)//((int)a[1] == 3 || (int)a[1] == 9 || (int)a[1] == 7) && (int)a[0] == 11)
            //        {
            //            for (int i = 0; i < modN; i++)
            //            {
            //                int loc = i % ca.Count;
            //                Console.Out.Write((int)ca[loc] + "  ");
            //                if((int)ca[loc] < 10)
            //                {
            //                    Console.Write(" ");
            //                }
            //            }
            //            Console.Out.Write("\n");
            //        }
            //    }
            ////}

            int found = 0;//System.Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < testRing.Count; i++)
            {
                //if((int)testRing[i] % ignore == 0)
                //{
                //    continue;
                //}
                if (found == (int)testRing[i])
                {
                    Console.Out.Write("\n\nGot it! : " + (int)testRing[i] + "\n\n");
                }
                else
                {
                    Console.Out.Write((int)testRing[i] + " ");
                    if ((int)testRing[i] < 10)
                    {
                        Console.Out.Write(" ");
                    }
                }
            }
            Console.Out.WriteLine("\n\nThe count is: " + (testRing.Count-1));
            Console.ReadLine();
        }
    }
}
