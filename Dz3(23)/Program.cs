// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i;
int kube = 1;
Console.Write("Таблица кубов: ");

for (i = 1; i <= number; i++)
{
    kube = i * i * i;
    Console.Write(kube + " ");
}