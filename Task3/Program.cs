// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int size = 5;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}
System.Console.WriteLine($"Количетсов элементов массива: {size}");

double[] FillArray2(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintMinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
    double temp = Math.Round(arr.Max() - arr.Min(), 3);
    
    System.Console.WriteLine($"Минимальное значение массива {arr.Min()}, максимальное значение массива {arr.Max()}");
    System.Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {temp}");
    System.Console.WriteLine();
}
PrintMinMax(FillArray2(size));
System.Console.WriteLine();