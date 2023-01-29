//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int matrix = new Random().Next(2, 5);

Random randomNumber = new Random();
int[,] tableOne = new int[matrix, matrix];
int[,] tableTwo = new int[matrix, matrix];

Console.WriteLine("Заданы две матрицы: ");

for (int i = 0; i < matrix; i++)
{
    for (int j = 0; j < matrix; j++)
    {
        tableOne[i, j] = new Random().Next(10, 100);
        Console.Write(tableOne[i, j] + "  ");
    }
    Console.Write(" | ");

    for (int j = 0; j < matrix; j++)
    {
        tableTwo[i, j] = new Random().Next(10, 100);
        Console.Write(tableTwo[i, j] + "  ");
    }
    Console.WriteLine();
}

Console.WriteLine("Произведение этих двух матриц: ");
int[,] resultMatrix = new int[matrix, matrix];

for (int i = 0; i < matrix; i++)
{
    for (int k = 0; k < matrix; k++)
    {
        int result = 0;
        for (int j = 0; j < matrix; j++)
        {
            result = result + (tableOne[i, j] * tableTwo[j, k]);
        }
        resultMatrix[i, k] = result;
        Console.Write(resultMatrix[i, k] + " ");
    }
    Console.WriteLine();
}
