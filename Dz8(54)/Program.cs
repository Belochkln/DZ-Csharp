// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int row = new Random().Next(2, 4);
int column = new Random().Next(2, 4);

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
Console.WriteLine("Отсортированный массив: ");
int localMax;

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column ; j++)
    {
        for (int k = j + 1; k < column; k++)
        { // 5 6 8 0 3 2 10
            if (table[i, k] > table[i, j])
            {
                localMax = table[i, j];
                table[i, j] = table[i, k];
                table[i, k] = localMax;
            }
        }
        Console.Write(table[i, j] + "  ");
    }
    Console.WriteLine();
}

