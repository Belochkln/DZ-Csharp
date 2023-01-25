// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int row = new Random().Next(2, 8);
int column = new Random().Next(2, 8);

Random randomNumber = new Random();
int[,] table = new int[row, column];
int[] number = new int[row * column];
Console.WriteLine("Задан массив: ");

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        table[i, j] = new Random().Next(0, 100);
        Console.Write(table[i, j] + "  ");
    }
    Console.WriteLine();
}

Console.WriteLine("Среднее арифметиеское каждого столбца: ");

for (int i = 0; i < column; i++)
{
    int sum = 0;
    for (int j = 0; j < row; j++)
    {
        sum = sum + table[j, i];
    }
    Console.WriteLine($"{i+1}ого: {sum}");
}
