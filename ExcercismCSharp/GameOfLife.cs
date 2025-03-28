using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcercismCSharp
{
    public static class GameOfLife
    {
        public static int numberOfLiveNeighbors(int i, int j, int[,] matrix)
        {
            if (i+1 < matrix.GetLength(1) && matrix[j, i + 1] == 1)
                return 1;
            else
                return 0;
        }

        // Any cell with exactly two or three live neighbors lives on
        public static bool canLiveOn(int i, int j, int[,] matrix) 
        {
            int liveNeighbors = numberOfLiveNeighbors(i, j, matrix);
            if (liveNeighbors >= 2 && liveNeighbors <= 3)
                return true;
            else 
                return false;
        }

        public static int[,] Tick(int[,] matrix)
        {
            int[,] newBoard = matrix;

            //blanket, all live cells die
            for( int j = 0; j <matrix.GetLength(0); ++j)
            {
                for (int i= 0; i < matrix.GetLength(1); ++i)
                {
                    //do some check to figure out adjacency
                    if (matrix[j, i] == 1)
                    {
                        if(!canLiveOn(i,j, matrix))
                            newBoard[j, i] = 0;
                    }
                }
            }

            return newBoard;
        }
    }

}
