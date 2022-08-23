// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введи тут трехзначное число - ");
int x;
x = Convert.ToInt32(Console.ReadLine());
string numbers = Convert.ToString(x);
Console.WriteLine(numbers[1]);
