// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число:"); 

double Num = Convert.ToDouble(Console.ReadLine());

if (Num % 2 == 0)

Console.WriteLine("Число чётное"); 

else

Console.WriteLine("Число не чётное");