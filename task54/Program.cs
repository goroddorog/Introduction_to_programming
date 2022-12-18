// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    temp = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
    return array;
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
Console.WriteLine("\nОтсортированный массив:");
SortArray(matrix);
PrintArray(matrix);