// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiArray(int[,] array1, int[,] array2)
{
    int[,] multiMatrix = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                // for (int m = 0; m < array2.GetLength(1); m++)
                // {
                    multiMatrix[i, j] += array1[i, k] * array2[k, j];
                // }
            }
        }
    }
    return multiMatrix;
}

Console.WriteLine("Введите размер матрицы:");
int row = Convert.ToInt32(Console.ReadLine());
int col = row;

int[,] matrix1 = GenerateArray(row, col);
int[,] matrix2 = GenerateArray(row, col);
Console.WriteLine("Исходные массивы:");
PrintArray(matrix1);
Console.WriteLine($"");
PrintArray(matrix2);
Console.WriteLine($"Произведение двух матриц:");
PrintArray(MultiArray(matrix1, matrix2));
