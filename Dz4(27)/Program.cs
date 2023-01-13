// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int result = 0;
int num = Convert.ToInt32(number);
int j = 0;

for (int i = 1; i <= number.Length; i++)
{
    while (j < i)
    {
        result = result + ((num / (int)Math.Pow(10, (number.Length - i))) - ((num / (int)Math.Pow(10, (number.Length - j))) * 10));
        j++;
    }
}

if(result < 0)   result = Math.Abs(result);

Console.WriteLine("Сумма всех цифр числа: ");
Console.WriteLine(result);
