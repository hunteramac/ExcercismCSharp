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
            int numNeighbors = 0;

            //Check right
            if (i+1 < matrix.GetLength(1) && matrix[j, i + 1] == 1)
                ++numNeighbors;

            //Check down right
            if (j + 1 < matrix.GetLength(0) && i + 1 < matrix.GetLength(1) && matrix[j + 1, i + 1] == 1)
                ++numNeighbors;


            //Check down
            if (j + 1 < matrix.GetLength(0) && matrix[j + 1, i] == 1)
                ++numNeighbors;

            //Check down left
            if (j + 1 < matrix.GetLength(0) && i - 1 >= 0&& matrix[j + 1, i-1] == 1)
                ++numNeighbors;

            //Check left
            if (i-1 >= 0 && matrix[j, i - 1] == 1)
                ++numNeighbors;

            // check upper left
            if ((i - 1 >= 0) && (j - 1 >= 0) && matrix[j-1, i - 1] == 1)
                ++numNeighbors;

            //Check up
            if (j-1 >=0 && matrix[j-1, i] ==1)
                ++numNeighbors;

            //Check upper right
            if (j - 1 >= 0 && i + 1 < matrix.GetLength(1) && matrix[j - 1, i + 1] == 1)
                ++numNeighbors;


            //

            return numNeighbors;
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

        public static bool canBecomeAlive(int i, int j, int[,] matrix)
        {
            int liveNeighbors = numberOfLiveNeighbors(i, j, matrix);
            if (liveNeighbors == 3)
                return true;
            else 
                return false;
        }

        public static int[,] Tick(int[,] matrix)
        {
            int[,] newBoard = new int[matrix.GetLength(0), matrix.GetLength(1)];
            Array.Copy(matrix,0,newBoard, 0, matrix.Length);

            // for all cells
            for( int j = 0; j <matrix.GetLength(0); ++j)
            {
                for (int i= 0; i < matrix.GetLength(1); ++i)
                {
                    
                    // If a live cell
                    if (matrix[j, i] == 1)
                    {
                        //do some check to figure out adjacency
                        if (!canLiveOn(i,j, matrix))
                            newBoard[j, i] = 0;
                    } 
                    //dead cell
                    else
                    {
                        if(canBecomeAlive(i,j,matrix))
                            newBoard[j, i] = 1;
                    }
                }
            }

            return newBoard;
        }
    }

}
