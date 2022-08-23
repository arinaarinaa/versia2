// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введи тут число - ");
int x = Convert.ToInt32(Console.ReadLine());
string index = Convert.ToString(x);
int n = index.Length;
if (n>2)
{
    Console.WriteLine(index[2]);
}
else
{
    Console.WriteLine("Тут ниче нет");
}