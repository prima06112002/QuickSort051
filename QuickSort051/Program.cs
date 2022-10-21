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
            int temp;
            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void q_short(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;

            //partition the list into two part:
            //one containing element less that or equal to pivot
            //Outher coontaining element greather than pivot 

            i = low + 1;
            j = high;

            pivot = arr[low];

            while (i <= j)
            {
                //Search for an element greater than pivot
                while ((arr[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;

                }
                cmp_count++;

                //search for an element less than or equal to pivot
                while ((arr[j] <= pivot) && (j >= low))
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;

                if (i < j) // if the greater element is on the left of the element
                {
                    //swap the element at index i whit the element at index j
                    swap(i, j);
                    mov_count++;

                }
            }
            //j now contains the index of the last element in the sorted list

            if (low < j)
            {
                //move the pivot to its correct position in the list
                swap(low, j);
                mov_count++;
            }
            //sort the list on the left of pivot using quick sort
            q_short(low, j - 1);

            //sort the list on the right of pivot using quick sort
            q_short(j + 1, low);

        }
        void display()
        {
            Console.WriteLine("\n-------------------");
            Console.WriteLine(" Sorted array element");
            Console.WriteLine("---------------------");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("\nNumber of comparison:" + cmp_count);
            Console.WriteLine("\nNumber of data movemenet:" + mov_count);

        }
        int getSize()
        {
            return n;
        }

        static void main(string[]args)
        {
            //declaring the object of the class
            program myList = new program();
            //Aceept array element
            myList.input();
            //caliing the sorting function
            //firts call to quick sort alogarithm
            myList.q_short(0, myList.getSize() - 1);
            //display sorted array
            myList.display();
            // to exit from the console
            Console.WriteLine("n\npress enter To Exit.");
            Console.Read();
        }



        
    }
}

      


