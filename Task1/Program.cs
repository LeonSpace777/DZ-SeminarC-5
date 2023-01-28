// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int size = 10;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintResult(int[] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + ", ");
        if (array[i] % 2 == 0) num++;
    }

    System.Console.WriteLine($"Количество четных чисел {num}");
}

PrintResult(FillArray(size));