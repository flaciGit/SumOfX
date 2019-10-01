using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SumOfXExample
{
    public class SumOfX
    {
        int[] list;

        SumOfX() {
            list = new int[] { };
        }

        public void Append(int[] newList) {

            printArray("\nNew list has been added to the list: ",newList);

            list = list.Concat(newList).ToArray();

        }

        public void printArray(string message, int[] arr) {

            Console.WriteLine(message);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
        }
        
        public bool Contains(int sumNumber, int x) {

            printArray("Current list:",list);

            if (x > list.Length) {
                Console.WriteLine("Given x number: "+ x +" is greater than the current list length! ");
                return false;
            }

            int sum = 0;
            int[] subList;
            for (int i = 0; i <= list.Length - x; i++) {
                sum = 0;
                subList = new int[] { };

                for (int j = i; j < i + x; j++){
                    sum += list[j];
                    subList = subList.Concat(new int[] { list[j] }).ToArray();
                }
                if (sum == sumNumber)
                {
                    Console.WriteLine("The list contains the sum: " + sumNumber + " as " + x + " concurrent sumarization of the numbers!");
                    printArray("Subset of the list:",subList);
                    return true;
                }
            }

            Console.WriteLine("The list does not contains the sum: " + sumNumber + " as " + x + " concurrent sumarization of the numbers!");
            return false;
        }

        static void Main(string[] args)
        {

            SumOfX sumOfX = new SumOfX();

            sumOfX.Append(new int[] { 1, 2, 3 });
            sumOfX.Contains(9,4);

            sumOfX.Append(new int[] { 4 });
            sumOfX.Contains(9, 3);

            sumOfX.Append(new int[] { 4 });
            sumOfX.Contains(7, 3);

            
            Console.ReadKey();
            
        }
    }
}
