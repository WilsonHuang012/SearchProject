using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(1, 101));
            }

            Console.WriteLine("List:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            bool b = false;

            list.Sort();
            #region Print Sorted list
            Console.WriteLine("Sorted list:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            #endregion

            int target = int.MinValue;
            do
            {
                Console.WriteLine("Please input an integer:");
                string input = Console.ReadLine();
                b = int.TryParse(input, out target);
            } while (!b);
            int index = SearchAlgorithm.BinarySearch(list, target);
            //int index = list.BinarySearch(target);
            if (index < 0)
            {
                Console.WriteLine("Input integer not found!");
            }
            else
            {
                Console.WriteLine("Found integer {0} at index {1}", list[index], index);
            }
            Console.ReadLine();
        }
    }
}
