using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms.Patterns
{
    class SierpinskiTriangle
    {
        public SierpinskiTriangle()
        {
            int n = 16;

            // Initializing matrix.
            string[][] matrix = new string[n][];
            for (int i = 0; i < n; i++) { 
                matrix[i] = new string[n];
                for (int j = 0; j < n; j++)
                    matrix[i][j] = " ";
            }

            // Creating simple pyrmid pattern in matrix.
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int y = i - 1;
                    int x = n - i + j;
                    matrix[x][y] = "* ";
                }
            }

            // Drawing Seirpinski triangle inside matrix.
            DrawSeirpinski(matrix, n, new int[] { 0, 0 }, new int[] { n - 1, 0 });

            // Printing the matrix.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
        }

        void DrawSeirpinski(string[][] matrix, int n, int[] a, int[] b)
        {
            if (n < 4)
                return;

            int eraserSize = n / 2;

            for (int i = 1; i < eraserSize; i++)
            {
                int y = a[0] + eraserSize + i - 1;
                for (int k = 0,j = eraserSize; j > i; k++, j--)
                {
                    int x = b[1] + eraserSize + k;
                    matrix[y][x] = "  ";
                }
            }

            // Recursively erase inner triangle for remaining 3 triangles.
            // Upper triangle
            int[] a1 = a;
            int[] b1 = new int[] { n / 2 - 1, n / 2 + b[1] };
            DrawSeirpinski(matrix, n / 2, a1, b1);

            // Lower left triangle
            int[] a2 = new int[] { n / 2, a[1] };
            int[] b2 = new int[] { n - 1, b[1] };
            DrawSeirpinski(matrix, n / 2, a2, b2);

            // Lower right triangle
            int[] a3 = new int[] { n / 2, n / 2 + a[1] };
            int[] b3 = new int[] { n - 1, n / 2 + b[1] };
            DrawSeirpinski(matrix, n / 2, a3, b3);
        }
    }
}
