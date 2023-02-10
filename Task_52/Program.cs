/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] Array = { { 0, 3, 6, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

void SumIndexJ ( int [,] Array)
{
    double[] sum = new double[Array.GetLength(1)];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            sum[j] = Array[i, j] + sum [j];
        }
    }
    foreach (double average in Array)
    Console.WriteLine($"Среднее арифметическое {Math.Round(average / Array.GetLength(0), 1)} ");
}

SumIndexJ(Array);