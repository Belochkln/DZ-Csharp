//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Задайте две матрицы.");
Console.WriteLine("Задайте кол-во строк 1-ой матрицы матрицы: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте кол-во строк 2-ой матрицы матрицы: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте кол-во столбов 1-ой матрицы матрицы: ");
int column1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте кол-во столбов 2-ой матрицы матрицы: ");
int column2 = Convert.ToInt32(Console.ReadLine());

if (column1 != row2) Console.WriteLine("Эти матрицы не перемножить.");
else
{
    Console.WriteLine("Полученные матрицы:");
    int[,] tableOne = new int[row1, column1];
    int[,] tableTwo = new int[row2, column2];

    Console.WriteLine("Первая матрица:");
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < column1; j++)
        {
            tableOne[i, j] = new Random().Next(10, 100);
            Console.Write(tableOne[i, j] + "  ");
        }
        Console.WriteLine(" ");
    }
    Console.WriteLine("Вторая матрица:");
    for (int i = 0; i < row2; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            tableTwo[i, j] = new Random().Next(10, 100);
            Console.Write(tableTwo[i, j] + "  ");
        }
        Console.WriteLine(" ");
    }

    Console.WriteLine("Произведение этих двух матриц: ");
    int[,] resultMatrix = new int[row2, column1];

    for (int i = 0; i < row1; i++)
    {
        for (int k = 0; k < column2; k++)
        {
            int result = 0;
            for (int j = 0; j < column1; j++)
            {
                result = result + (tableOne[i, j] * tableTwo[j, k]);
            }
            resultMatrix[i, k] = result;
            Console.Write($"{resultMatrix[i, k]}  ");
        }
        Console.WriteLine();
    }
}