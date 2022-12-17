// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число:"); 

double Num = Convert.ToDouble(Console.ReadLine());

double chet = 0;
int i;
Console.Write("Чётные числа до числа " + Num + ": "); 
for ( i = 1; i < Num; i++ )
{
chet = 0 + i;

if ( chet % 2 == 0 )
{

Console.Write( chet + " ");

}

}



