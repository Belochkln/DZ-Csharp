﻿// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int row = new Random().Next(2, 8);
int column = new Random().Next(2, 8);

Random randomNumber = new Random();
int[,] table = new int[row, column];
int[] number = new int[row * column];
int rank = 0;
Console.WriteLine("Задан массив: ");

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        table[i, j] = new Random().Next(0, 100);
        Console.Write(table[i, j] + "  ");
        number[rank] = table[i, j];
        rank++;
    }
    Console.WriteLine();
}

Console.Write("Введите номер элемента: ");
int position = Convert.ToInt32(Console.ReadLine());
if (position <= 0 || position > (row*column))
{
    Console.WriteLine("Нету такого элемента ");
}
else Console.WriteLine($"{position} = {number[position - 1]}");
