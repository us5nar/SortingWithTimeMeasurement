using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISorterNameSpace
{
    public interface ISorter
    {
        // interface definition
        // interface members:
        // Method Sort with 2 overloads
        // Sort the array
        int[] Sort(int[] arrayToSort);
        // Sort input array and measure sorting time
        int[] Sort(int[] arrayToSort, out int sortingTime);
    }
}
