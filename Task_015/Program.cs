// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Write("Введите номер дня недели, чтобы узнатьвыходной ли это день: ");

int num = Convert.ToInt32(Console.ReadLine());

 if ((num > 0 && num < 8) & (num == 7)) Console.WriteLine($"{num} да, это выходной");

else if ((num > 0 && num < 8) & (num == 6)) Console.WriteLine($"{num} да, это выходной");

else Console.WriteLine($"{num} нет, это не выходной");


