// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

Random randomNumber = new Random();
double[,] table = new double[row, column];
Console.WriteLine("Полученный массив: ");

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        table[i, j] = Math.Round((randomNumber.NextDouble() * randomNumber.Next(-100, 100)), 1);
        Console.Write(table[i, j] + "  ");
    }
    Console.WriteLine();
}
