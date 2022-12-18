// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random random = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = random.Next(0, 9);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[] SumArray(int[,] array)
{
    int sumTemp = 0;
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumTemp += array[i, j];
        }
        sum[i] = sumTemp;
        // Console.WriteLine($"{sum[i]}");
        sumTemp = 0;
    }
    return sum;
}

int MinSumRow(int[] minRow)
{
    int min = minRow[0];
    int minIndex = 0;
    for (int i = 0; i < minRow.Length; i++)
    {
        if (minRow[i] > min)
        {
            min = minRow[i];
            minIndex = i;
        }
        
    }
    return minIndex;
}

Console.WriteLine("Введите кол-во строк массива:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов массива:");
int col = Convert.ToInt32(Console.ReadLine());

// int row = 3;
// int col = 4;
int[,] matrix = GenerateArray(row, col);
Console.WriteLine("Исходный массив:");
PrintArray(matrix);
// Console.WriteLine("\nСумма строк:");
int[] sum = SumArray(matrix);
int minRow = MinSumRow(sum);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRow} строка ");
