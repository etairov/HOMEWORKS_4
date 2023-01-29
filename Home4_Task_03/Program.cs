//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
//---------------------------

int[] GetRandomArray()
{
    int[] array = new int[8];
    Random randomNumber = new Random();
    for (int i = 0; i < array.Length-1; i++)
    {
        array[i] = randomNumber.Next(-11, 11);
    }
    return array;
}

void printArray(int[] array)
{
    Console.Write('[');
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
}

int[] randomArray = GetRandomArray();

Console.WriteLine($"Произвольно заданный массив чисел:");
printArray(randomArray);


