//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите число с которого начём: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число до которого складываем: ");
int endNumber = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = startNumber; i <= endNumber; i++)
{
    sum = sum + i;
}

Console.WriteLine($"Сумма всех натуральных элементов в промежутке от {startNumber} до {endNumber} = {sum}");

