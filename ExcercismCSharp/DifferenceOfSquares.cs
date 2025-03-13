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

    public static int CalculateSumOfSquares(int max)
    {
        IEnumerable<int> range = Enumerable.Range(0, max + 1);
        //non lib soloution
        int sum = 0;
        foreach(int index in range)
        {
            sum += index * index;
        }
        return sum;
    }
}
