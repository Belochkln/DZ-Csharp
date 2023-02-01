// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.Read());

string ShowNumbers(int N)
{
    string result = String.Empty;
    for (int i = (N - 48); i > 0; i--)
    {
        result += $"{i} ";
    }
    return result;
}
Console.WriteLine("Все натуральные числа в промежутке от " + (number - 48) + " до 1: ");
Console.WriteLine(ShowNumbers(number));