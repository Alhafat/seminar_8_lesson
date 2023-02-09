// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку 
// массива.

int[,] GetArray()
{
    int[,] array = new int[3, 3];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(-5, 5);
        }
    }
    return array;
}

void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (numbers[i, j] >= 0) Console.Write(" " + $"{numbers[i, j]}" + "\t");
            else Console.Write($"{numbers[i, j]}" + " \t");
        }
        Console.WriteLine();
    }
}

void newArray(int[,] numbers)
{
    int count;
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        count = numbers[0, i];
        numbers[0, i] = numbers[numbers.GetLength(0) - 1, i];
        numbers[numbers.GetLength(0) - 1, i] = count;
    }
}

void Main()
{
    int[,] numbers = GetArray();
    PrintArray(numbers);
    Console.WriteLine();
    newArray(numbers);
    PrintArray(numbers);
}

Main();

// int[,] GetRandomMatrix(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void TransformMatrix(int[,] matrix)
// {
//     int temp;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         temp = matrix[0, i];
//         matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
//         matrix[matrix.GetLength(0) - 1, i] = temp;
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// int[,] matrix = GetRandomMatrix(m: 4, n: 5, minValue: 1, maxValue: 10);
// PrintArray(matrix);
// TransformMatrix(matrix);
// Console.WriteLine();
// PrintArray(matrix);