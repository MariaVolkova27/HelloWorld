// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите порядковый номер дня недели:");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

if (number == 6 || number == 7)
    Console.WriteLine($"{number} -> да");
else if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
    Console.WriteLine($"{number} -> нет");
