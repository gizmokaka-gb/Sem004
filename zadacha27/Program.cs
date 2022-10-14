// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int numbers = int.Parse(Console.ReadLine());

int SumNumber(int numbers)
{

    int counter = Convert.ToString(numbers).Length;
    int digit = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        digit = numbers - numbers % 10;
        result = result + (numbers - digit);
        numbers = numbers / 10;
    }
    return result;
}

int sumNumber = SumNumber(numbers);
Console.WriteLine($"Сумма цифр в числе: {sumNumber}.");