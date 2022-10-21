using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort051
{
    class program
    {
        //aray of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; // number of comparasion
        private int mov_count = 0; // number of data movement

        // Number of element in array
        private int n;


        void input()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of element in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\narray can have maximum 20 element \n");
            }
            Console.WriteLine("\n=====================");
            Console.WriteLine("Enter array Element");
            Console.WriteLine("\n=====================");

            //get array element
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        //swaps the element at index x with the element at index y
        void swap(int x, int y)
        {

        }


        }
    }
}

      


