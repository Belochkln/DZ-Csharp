//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Массив: ");

double[] array = new double[5];
double result = 0;
double max = array[0];
double min = array[0];
Random random_number = new Random();


for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round((random_number.NextDouble() * random_number.Next(-100,100)), 1);
    Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }

    else

    if (min > array[i])
    {
        min = array[i];
    }

}

result = (max - min);
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + max + " - " + min + " = " + result);
