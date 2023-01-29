// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int row = new Random().Next(2, 6);
int column = new Random().Next(2, 6);

Random randomNumber = new Random();
int[,] table = new int[row, column];
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

Console.WriteLine();
int[] rowSum = new int[row];
for (int i = 0; i < row; i++)
{
    int sum = 0;
    for (int j = 0; j < column; j++)
    {
        sum = sum + table[i, j];
    }
    rowSum[i] = sum;
    Console.WriteLine("Сумма " + (i + 1) + "-ой строки = " + rowSum[i]);
}

Console.WriteLine();
int minRow = rowSum[0];
int minRowIndex = 1;
for (int i = 0; i < row; i++)
{
    if (minRow > rowSum[i])
    {
        minRow = rowSum[i];
        minRowIndex = i + 1;
    }
}
Console.WriteLine("Строка с наименьшей суммой элементов: " + minRowIndex);



