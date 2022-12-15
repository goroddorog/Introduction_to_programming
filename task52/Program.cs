// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] array = new double[4]; 

double[,] matrix = new double[,]
    {
        {1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {0, 0, 0, 0}
    };
    
Console.WriteLine($"Заданый массив:");
    
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
        array[i] += matrix[j,i];
        // Console.Write($"({array[i]}) ");
        
    }
    // Console.WriteLine("Сумма в {0} столбце: {1}", i, array[i]);
    Console.WriteLine($"");    
}

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round((array[i] / 3), 1);
}

Console.WriteLine("\nСреднее арифметическое каждого столбца: {0}",String.Join(" ",array));

