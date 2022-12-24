// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int i;

if (Convert.ToInt32(number) > 0)
{
    if (number.Length == 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
            Console.WriteLine("Полиндром");
        else
            Console.WriteLine("Не Полиндром");
    }
    else
        Console.WriteLine("Это не пятизначное число");
}

else
{
    if (number.Length == 5)
    {
        if (number[1] == number[5] && number[2] == number[4])
            Console.WriteLine("Полиндром");
        else
            Console.WriteLine("Не Полиндром");
    }
    else
        Console.WriteLine("Это не пятизначное число");
}