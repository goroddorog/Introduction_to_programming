// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine($"Введите искомую строку:");
int positionRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите искомый столбец:");
int positionCol = Convert.ToInt32(Console.ReadLine());
int searchNumber = 0;

if (positionRow > 3 || positionRow < 1 || positionCol > 4 || positionCol < 1)
{
    Console.WriteLine($"Такой позиции нет в массиве");
    return;
}
else
{
    int[,] matrix = new int[,]
    {
        {1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}
    };
    
    Console.WriteLine($"Заданый массив:");
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
            if (i+1 == positionRow && j+1 == positionCol)
            {
                searchNumber = matrix[i,j];
            }
        }
        Console.WriteLine($"");
    }
    Console.WriteLine($"Значение элемента: {searchNumber}");
    
}
