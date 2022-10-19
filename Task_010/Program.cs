// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.WriteLine($"Ввведите трех значное число от 100 до 999: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number > 99) Console.WriteLine($"Второе число {((number - (number % 10))% 100)/10}");

