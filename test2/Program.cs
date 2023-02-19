// 13 программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("введите число");
 string a = Console.ReadLine();
 int b = a.Length;
 if (b<3)
 {
    Console.WriteLine ("NO");
 }
 else
 {
     Console.WriteLine (a[2]);
 }