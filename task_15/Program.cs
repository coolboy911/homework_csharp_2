// Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.Write("Введите номер дня недели ");
int num = int.Parse(Console.ReadLine()!);
if (num == 6 || num == 7) Console.WriteLine("ДА");
else Console.WriteLine("НЕТ");
