// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

int firstDigit = number / 100;
int secondDigit = (number - firstDigit*100) / 10;

Console.WriteLine($"{number} -> {secondDigit}");
