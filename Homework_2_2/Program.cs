// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
string input = Console.ReadLine();

int length = input.Length;
int symbol = 3;

if (length >= symbol)
    Console.WriteLine($"{input} -> {input[symbol - 1]}");
else
    Console.WriteLine($"{input} -> третьей цифры нет");
