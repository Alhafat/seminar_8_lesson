// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это 
// невозможно, программа должна вывести сообщение для 
// пользователя.

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

void transformArray(int[,] numbers)
{
    int[,] matrix = new int[numbers.GetLength(0), numbers.GetLength(1)];
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        for (int j = 0; j < numbers.GetLength(0); j++)
        {
            if (numbers.GetLength(0) == numbers.GetLength(1))
            {
                matrix[i, j] = numbers[j, i];
            }
            else
            {
                System.Console.WriteLine("Матрица нетранспорентна");
                return;
            }
        }
    }
}



void Main()
{
    int[,] numbers = GetArray();
    PrintArray(numbers);
    transformArray(numbers);
    System.Console.WriteLine();
}

Main();



// int[,] GetArray(int m, int n, int minValue, int maxValue)
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

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]}\t ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] Bardak(int[,] array)
// {
//     int hight = array.GetLength(0);
//     int width = array.GetLength(1);

//     int[,] bardakArray = new int[width, hight];
//     for (int i = 0; i < hight; i++)
//     {
//         for (int j = 0; j < width; j++)
//         {
//             bardakArray[i, j] = array[j, i];
//         }
//     }
//     return bardakArray;

// }

// void Main()
// {
//     Console.Clear();
//     Console.Write("Введите кол-во строк: ");
//     int row = int.Parse(Console.ReadLine()!);
//     Console.Write("Введите кол-во столбцов: ");
//     int col = int.Parse(Console.ReadLine()!);
//     int[,] ourArray = GetArray(row, col, 1, 9);
//     PrintArray(ourArray);

//     System.Console.WriteLine();
//     if (ourArray.GetLength(0) != ourArray.GetLength(1))
//     {
//         System.Console.WriteLine("Преобразование невозможно");
//     }
//     else
//     {
//         PrintArray(Bardak(ourArray));
//     }


// }

// Main();