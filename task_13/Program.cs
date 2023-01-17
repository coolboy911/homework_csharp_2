// Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что 
// третьей цифры нет. (Цифры считать справа налево).
Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine()!);
if (num / 100 > 0)
{
    int num3 = num / 100 % 10;
    Console.WriteLine(num3);
}
else Console.WriteLine("третьей цифры нет");