/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 4, 6] -> 0*/


int[] CreateArray()
{
    int size = InputValue("Введите размер массива");
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 100);
    }
    return array;
}

void PrintArray(int[] array, string message)
{
    System.Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int SumArrayNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int InputValue(string message)
{
    System.Console.WriteLine(message + ":");
    return Convert.ToInt32(Console.ReadLine());
}

int[] baseArray = CreateArray();
PrintArray(baseArray, "Базовый массив:");
System.Console.WriteLine($"Cумма элементов массива, стоящих на нечётных позициях = {SumArrayNumbers(baseArray)}");