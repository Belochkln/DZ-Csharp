//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа:"); 

double Num1 = Convert.ToDouble(Console.ReadLine());

double Num2 = Convert.ToDouble(Console.ReadLine());

double Num3 = Convert.ToDouble(Console.ReadLine());

double max = Num1;

if (Num2 > Num1)
{
    max = Num2;
    if(Num3 > Num2)
    max = Num3;

}
else
{
if (Num3 > Num1)
{
max = Num3;
}
}
Console.WriteLine("Максимальное число: " + max);