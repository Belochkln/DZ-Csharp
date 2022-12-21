// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день недели (число): ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 6)
    Console.WriteLine("Рабочий день");
else
    Console.WriteLine("Выходной день");
