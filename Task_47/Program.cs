/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

// 1. Matrix initialization
double [,] InitMatrix(double rows, double columns)
{
    double [,] matrix = new double[3,4];
    Random rnd = new Random();
    int minimum = -100; 
    int maximum = 100;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.NextDouble() * (maximum - minimum) + minimum;;
        }
    }

    return matrix;
}

// 2. Matrix print
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    { 
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }

        Console.WriteLine();
    }
}

double [,] matrix = InitMatrix(3,4);
PrintMatrix(matrix);



