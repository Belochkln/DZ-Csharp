// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число:" + " ");
string number = Console.ReadLine();

if (Convert.ToInt32(number) > 0)
{
    if (number.Length < 3)
        Console.Write("Третьей цифры нету");
    else
        Console.Write("Третье число: " + number[2]);
}


if (Convert.ToInt32(number) < 0)
{
    if (number.Length < 4)
        Console.Write("Третьей цифры нету");
    else
        Console.Write("Третье число: " + number[3]);
}
