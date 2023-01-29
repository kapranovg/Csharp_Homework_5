/*Задайте одномерный массив, заполненный случайными числами. 
Найдите второй максимальный элемент данного массива
[1, 2, 3, 5, 7, 9] -> 9
[2, 3, 4, 5, 5] -> 4*/

int[] CreateArray()
{
    int size = InputValue("Введите размер массива");
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 101);
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

bool LenghtArray(int[] array)
{
    if (array.Length >= 2)
    {
        return true;
    }
    else
    {
        System.Console.WriteLine("Массив должен быть больше одного элемента.");
        return false;
    }
}

void FindSecondMax(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }

    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[array.Length - 1])
        {
            System.Console.WriteLine("Второго максимального числа в массиве не существует.");
            break;
        }
        if (array[i] > array[i + 1])
        {
            System.Console.WriteLine($"Второе максимальное число в массиве = {array[i + 1]}");
            break;
        }
    }
}

int InputValue(string message)
{
    System.Console.WriteLine(message + ":");
    return Convert.ToInt32(Console.ReadLine());
}

int[] baseArray = CreateArray();

if (LenghtArray(baseArray))
{
    PrintArray(baseArray, "Базовый массив:");
    FindSecondMax(baseArray);
}

