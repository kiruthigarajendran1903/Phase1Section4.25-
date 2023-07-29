using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._25
{
    internal class Program
    {
        public static void Array(string[] arr)
        {
            int n = arr.Length, i, j, flag;
            string val;
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val.CompareTo(arr[j]) < 0)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }


            }
            Console.WriteLine("After Insertion Sort");
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
        }

    
    static void Main(string[] args)
        {
            Console.WriteLine("Enter No of Elements");
            int n = int.Parse(Console.ReadLine());
            string[] Arr = new string[n];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < n; i++)
            {
                Arr[i] = Console.ReadLine();

            }
            Console.WriteLine("Array Elements are");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Arr[i]);
            }

            Array(Arr);
            Console.ReadKey();
        }
    }
}
