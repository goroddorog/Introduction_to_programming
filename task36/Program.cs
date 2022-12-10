// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int ReadArray(int length)
{
    int[] array = new int[length];
    int sum_numbers = 0;
    Console.WriteLine("Элементы массива: ");
    for (int i = 0; i < length; i++)
    {
        
        array[i] = new Random().Next(1,100);
        if (i % 2 == 1)
            {
                sum_numbers += array[i];
            }
        Console.Write($"{array[i]} ");
    }
    return sum_numbers;
}

Console.WriteLine("Введите количество элементов массива:");
int array_length = Convert.ToInt32(Console.ReadLine());

int even_number = ReadArray(array_length);
Console.WriteLine($"\nСумма чисел на нечетных позициях: {even_number}");