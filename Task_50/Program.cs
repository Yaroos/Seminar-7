/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7 */

// 1. Matrix initialization
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("ВвелИ не корректное число. Повторите ввод.");
        }
    }

    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for ( int j = 0; j < columns; j++)
        { 
            matrix[i,j] = rnd.Next(1,10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
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
int firstIndex = GetNumber("First Number - [i]: ");
int secondIndex = GetNumber("Second Number - [j]: ");
int [,] matrix = InitMatrix(3,4);
PrintMatrix(matrix);

Console.WriteLine();

//                                3            4
int ProverkaAndVivod (int [,] matrix)
{
    int numberOfElement = 0;
    int count = matrix.GetLength(0);
    if(count > matrix.GetLength(1))
    count = matrix.GetLength(1);
    
    if (firstIndex > count && secondIndex > count)
    {
        Console.WriteLine("Индекса нет");
    }
    else
    {
        Console.WriteLine(matrix[firstIndex,secondIndex]);
    }
    return numberOfElement;
}   

ProverkaAndVivod(matrix);