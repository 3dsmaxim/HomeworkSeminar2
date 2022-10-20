// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.WriteLine($"Ввведите трех значное целое число: ");

int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number < 1000 && number > 99) Console.WriteLine($"Вторая цифра {((number - (number % 10))% 100)/10}");

