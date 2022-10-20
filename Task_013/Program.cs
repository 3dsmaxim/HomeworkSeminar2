// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.




int CountNumber(int number)


{
    int count = 0;
    while (number > 0)
    {
        number = (number - (number % 10)) / 10;
        count++;
    }
    return count;

}

Console.WriteLine($"Ввведите  целое число: ");

int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int count = 3;
int countMax = CountNumber(number);

if (countMax > 2)
{
    while (count < countMax)
    {
        number = (number - (number % 10)) / 10;

        count = count + 1;
    }

    Console.WriteLine($"Третья цифра: {number % 10}.");
    
}

else Console.WriteLine($"Третьей цифры нет.");






