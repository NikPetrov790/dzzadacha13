// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трехзначное число");
int numbers = Convert.ToInt32(Console.ReadLine());
string threeNumbers = Convert.ToString(numbers);
    if (threeNumbers.Length > 2)
    {
        Console.Write("Третья цифра -  "+ threeNumbers[2]);
    }
    else
    {
        Console.Write(" третьей цифры нет");
    }

