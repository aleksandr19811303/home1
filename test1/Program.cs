// 10 программа принимает трехзначное число, на выходе показывает вторую цифру.
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int c = a%100;
int b = c/10;
Console.WriteLine (b);