// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите первое число для функции Аккермана: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Второе число для функции Аккермана: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
int result = 0;

int Ackerman(int m, int n)
{
    if (m == 0) result = n + 1;
    if (m > 0 && n == 0) result = Ackerman(m - 1, 1);
    if (m > 0 && n > 0) result = Ackerman(m - 1,Ackerman(m, n - 1));
    return result;
}

Console.Write("Функция Акермана = " + Ackerman(numberOne, numberTwo));