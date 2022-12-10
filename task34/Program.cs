// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int ReadArray(int length)
{
    int[] array = new int[length];
    int count_number = 0;
    Console.WriteLine("Элементы массива: ");
    for (int i = 0; i < length; i++)
    {
        
        array[i] = new Random().Next(100,1000);
        if (array[i] % 2 == 0)
            {
                count_number += 1;
            }
        Console.Write($"{array[i]} ");
    }
    return count_number;
}

Console.WriteLine("Введите количество элементов массива:");
int array_length = Convert.ToInt32(Console.ReadLine());

int even_number = ReadArray(array_length);
Console.WriteLine($"\nКоличество четных чисел: {even_number}");