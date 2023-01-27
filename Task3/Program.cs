/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3, 7.4, 22.3, 2, 78] -> 76*/

double[] CreateArray()
{
    int size = InputValue("Введите размер массива");
    Random rnd = new Random();
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100) + rnd.NextDouble();
    }
    return array;
}

void PrintArray(double[] array, string message)
{
    System.Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

(double, double) DiffMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return (max, min);
}

int InputValue(string message)
{
    System.Console.WriteLine(message + ":");
    return Convert.ToInt32(Console.ReadLine());
}

double[] baseArray = CreateArray();
PrintArray(baseArray, "Базовый массив:");
(double max, double min) = DiffMaxMin(baseArray);
System.Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементами массива = {max - min}");