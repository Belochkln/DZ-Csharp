// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите числа(через пробел): ");
double[] numbers = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToDouble);
int amount = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > 0) amount = amount + 1;
}

Console.WriteLine("Количество положительных чисел: " + amount);
