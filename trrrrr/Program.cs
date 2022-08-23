//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("День недели введи тут - ");
int x = Convert.ToInt32(Console.ReadLine());
if (x == 1 || x == 2 || x == 3 || x == 4 || x == 5)
{
    Console.WriteLine("Рабочий день(((");
}
if(x == 6 || x == 7)
{
    Console.WriteLine("А вот и выходной!");
}
if (x>7)
{
    Console.WriteLine("Такого дня нет, попробуй еще раз");
}