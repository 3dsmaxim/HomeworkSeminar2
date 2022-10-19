// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine($"Ввведите трех значное целое число: ");

int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number < 1000 && number > 99) Console.WriteLine($"Второе число {((number - (number % 10))% 100)/10}");