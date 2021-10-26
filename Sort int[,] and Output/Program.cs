using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = {
                          {0,1,2,3},
                          {3,6,1,7},
                          {5,8,1,0},
                          {5,1,7,3}
                         };

            string d = string.Empty;

            for (int y = 0; y < arr.GetLength(0); y++)
            {
                for (int x = 0; x < arr.GetLength(1); x++)
                {
                    d += arr[y,x].ToString();

                    if (arr.GetLength(1) == x + 1)
                    {
                        d = y + " - " + Sort(d).ToString();
                        Console.WriteLine(d);
                        d = string.Empty;
                    }
                }
            }

            Console.ReadLine();
        }
        static string Sort(string t)
        {

            string beta = "0123456789";
            string Sugar = string.Empty;

            int Index = 0;

            while (Index < beta.Length)
            {
                for (int net = 0; net < t.Length; net++)
                {

                    if (t[net] == beta[Index])
                    {

                        Sugar += t[net].ToString();

                        if (Sugar.Length < 2*t.Length-1)
                        {
                            Sugar += ",";
                        }

                        else
                        {
                            Sugar += ".";
                        }
                    }
                }

                Index++;

            }

                return Sugar;
        
        }
    }
}
