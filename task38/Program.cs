// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] ReadArray(int length)
{
    int[] array = new int[length];
    Console.WriteLine("Элементы массива: ");
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1,100);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int MaxMinArray(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    return (max-min);
}

Console.WriteLine("Введите количество элементов массива:");
int array_length = Convert.ToInt32(Console.ReadLine());

int[] array = ReadArray(array_length);
int max_minus_min = MaxMinArray(array);

Console.WriteLine($"\nРазницу между максимальным и минимальным элементов массива {max_minus_min}");