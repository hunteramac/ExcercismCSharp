using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 0;
        IEnumerable<int> range = Enumerable.Range(0, max + 1);
        sum = range.Sum();
        return sum * sum;
    }
}
