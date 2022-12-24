// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты точки A: ");
int i;
int j;
double[] dotA = new double[3];
for (i = 0; i < 3; i++)
    dotA[i] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
double[] dotB = new double[3];
for (j = 0; j < 3; j++)
    dotB[j] = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt((dotB[0] - dotA[0]) * (dotB[0] - dotA[0]) + (dotB[1] - dotA[1]) * (dotB[1] - dotA[1]) + (dotB[2] - dotA[2]) * (dotB[2] - dotA[2]));
Console.WriteLine("Расстояние между точками A и B: " + distance);