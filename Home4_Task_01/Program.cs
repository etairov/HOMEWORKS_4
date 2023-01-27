//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//---------------------

int GetNumbers(string message)
{
    int result1 = 0;
    int result2 = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result1))
        {
            break;
        }
        else Console.WriteLine("Ввели не число. Повторите ввод");

        if (int.TryParse(Console.ReadLine(), out result2))
        {
            break;
        }
        else Console.WriteLine("Ввели не число. Повторите ввод");
    }
    return result1;
    return result2;
}

int number1 = GetNumbers("Введите число A: ");
int number2 = GetNumbers("Введите число B: ");

double printDegree = Math.Pow(number1, number2);
Console.WriteLine($"{number1}, {number2} --> {printDegree}");