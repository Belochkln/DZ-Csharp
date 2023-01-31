// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int row = new Random().Next(2, 2);
int column = new Random().Next(2, 2);
int deep = new Random().Next(2, 2);

bool CompareAllElements(int[,,] array, int element)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                if (array[i, j, k] == element) return true;
            }
        }
    }
    return false;
}

Console.WriteLine("Полученный массив: ");
int[,,] Filltable(int[] array)
{
    int[,,] fillTable = new int[row, column, deep];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                int tableElement = new Random().Next(10, 20);
                if (CompareAllElements(fillTable, tableElement)) continue;
                fillTable[i, j, k] = tableElement;
            }
        }
    }
    return fillTable;
}

int[,,] table = Filltable(new int[] { row, column, deep });
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        for (int k = 0; k < deep; k++)
        {
            Console.Write($"{table[i, j, k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}