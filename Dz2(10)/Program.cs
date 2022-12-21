Console.Write("Введите трёхзначное число:" + " ");
int num = Convert.ToInt32(Console.ReadLine());
int one = num / 100;
int two = num / 10 - one * 10;
Console.Write(two);