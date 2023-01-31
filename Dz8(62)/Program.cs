// Напишите программу, которая заполнит спирально массив 4 на 4.
int row = 4;
int column = 4;
int[,] table = new int[row, column];
int number = 1;
for (int circle = 1; circle <= 2; circle++)
{
    int right = (-1 + circle);
    int down = (-1 + circle);
    int left = row - 1;
    int up = column - 1;
    while (up > (-1 + circle))
    {
        while (left > (-1 + circle))
        {
            while (down < row - 1)
            {
                while (right < column - 1)
                {
                    table[down, right] = number;
                    number++;
                    right++;
                }
                table[down, right] = number;
                number++;
                down++;
            }
            table[down, left] = number;
            number++;
            left--;
        }

        table[up, left] = number;
        number++;
        up--;
    }

    row = row - circle;
    column = column - circle;
}

for (int z = 0; z < 4; z++)
{
    for (int q = 0; q < 4; q++)
    {
        if (table[z, q] < 10) Console.Write("0" + table[z, q] + "  ");
        else Console.Write(table[z, q] + "  ");
    }
    Console.WriteLine();
}