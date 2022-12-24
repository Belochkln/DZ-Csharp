// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int one = number / 10000;
int two = number / 1000 - one * 10;
int four = (number % 100) / 10;
int five = number % 10;

if (number > 0)
{
    if (Convert.ToString(number).Length == 5)
    {
        if (one == five && two == four)
            Console.WriteLine("Чило палиндром");
        else
            Console.WriteLine("Чило не палиндром");
    }
    else
        Console.WriteLine("Это не пятизначное число.-_-");
}

else
{
    if (Convert.ToString(number).Length == 6)
    {
        if (one == five && two == four)
            Console.WriteLine("Чило палиндром");
        else
            Console.WriteLine("Чило не палиндром");
    }
    else
        Console.WriteLine("Это не пятизначное число. -_-");
}