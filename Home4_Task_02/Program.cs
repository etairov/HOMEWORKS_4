//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12
//--------------------

int GetNumbers(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else Console.WriteLine("Ввели не число. Повторите ввод");
    }
    return result;
}

int numberGet = GetNumbers("Введите любое число: ");

int SummOfDigits(int number)
{
int N = Math.Abs(numberGet);
int sum = 0;
int i = 0;
while (N > 0)
{
    i++;
    sum += N % 10;
    N /= 10;
}
    return sum;
}

int summDigit = SummOfDigits(numberGet);
Console.WriteLine($"{numberGet} --> {summDigit}");
