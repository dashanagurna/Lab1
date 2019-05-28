using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static int[] countingSort(int[] arr, int min, int max)
        {
            int[] count = new int[max - min + 1];
            int z = 0;

            for (int i = 0; i < count.Length; i++) { count[i] = 0; }
            for (int i = 0; i < arr.Length; i++) { count[arr[i] - min]++; }

            for (int i = min; i <= max; i++)
            {
                while (count[i - min]-- > 0)
                {
                    arr[z] = i;
                    z++;
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            string k;
            do
            {
                int[] nums = new int[10];
                Console.WriteLine("Введите десять чисел");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write("{0}-е число: ", i + 1);
                    nums[i] = Int32.Parse(Console.ReadLine());
                }


                Console.WriteLine("");
                int[] newarr = countingSort(nums, nums.Min(), nums.Max());
                Console.WriteLine("Вывод");

                for (int i = 0; i < newarr.Length; i++)
                    Console.Write(newarr[i] + " ");

                Console.WriteLine("");
                Console.WriteLine("Чтобы продолжить введите - y");
                k = Console.ReadLine();
            } while (k == "y");
            Console.ReadKey();
        }
    }
}
