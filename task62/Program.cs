// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// int matrixSize = 4;
// int[,] matrix = new int[matrixSize, matrixSize];
// FillArraySpiral(matrix, matrixSize);
// PrintArray(matrix);


// //  Функция заполнения массива по спирали начиная с 1
// void FillArraySpiral(int[,] array, int size)
// {
//     int i = 0, j = 0;
//     int value = 1;
//     for (int e = 0; e < size * size; e++)
//     {
//         int k = 0;
//         do { array[i, j++] = value++; } while (++k < size - 1);
//         for (k = 0; k < size - 1; k++) array[i++, j] = value++;
//         for (k = 0; k < size - 1; k++) array[i, j--] = value++;
//         for (k = 0; k < size - 1; k++) array[i--, j] = value++;
//         ++i; ++j;
//         if (size < 2) size = 0;
//         else size = size -2;
//         // size = size < 2 ? 0 : size - 2;
//     }
// }

// //  Функция вывода двумерного массива в терминал
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10)
//             {
//                 Console.Write("0" + array[i, j]);
//                 Console.Write(" ");
//             }
//             else Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

int matrixSize = 4;
matrixSize += 2;
int[,] matrix = new int[matrixSize, matrixSize];
int count = 1;
MakeBorder(matrix, matrixSize);
FillArraySpiral(1, 1);
Console.WriteLine();

MakeBorder(matrix, matrixSize);

void MakeBorder(int[,] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (i == 0 || j == 0 || i == size - 1 || j == size - 1) array[i, j] = 1;
            // else array[i, j] = 0;
            if (array[i, j] < 10)
            {
                Console.Write($"0{array[i, j]} ");
            }
            else Console.Write($"{array[i, j]} ");
            // Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArraySpiral(int row, int col)
{
    if (matrix[row, col] == 0)
    {
        // if (count < 10)
        // {
        //     Console.Write($"0{count} ");
        // }
        // else Console.Write($"{count} ");
        matrix[row, col] = count;
        count += 1;
        FillArraySpiral(row, col + 1); //вправо
        FillArraySpiral(row + 1, col); //вниз
        FillArraySpiral(row, col - 1); //влево
        FillArraySpiral(row - 1, col); //вверх
    }
}

