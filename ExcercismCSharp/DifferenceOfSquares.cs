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
        for(int i = 0; i<=max; ++i)
        {
            sum += i;
        }
        return sum*sum;
    }
}
