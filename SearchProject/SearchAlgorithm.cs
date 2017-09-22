using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProject
{
    public static class SearchAlgorithm
    {
        public static int BinarySearch(List<int> list, int target)
        {
            int left = 0;
            int right = list.Count - 1;
            while (left <= right)
            {
                int middle = Convert.ToInt32(right + left / 2);
                if (list[middle] == target)
                {
                    return middle;
                }
                else if (list[middle] > target)
                {
                    right = middle - 1;
                }
                else if (list[middle] < target)
                {
                    left = middle + 1;
                }
            }
            return int.MinValue;
        }
    }
}
