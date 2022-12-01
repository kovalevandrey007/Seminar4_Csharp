/*

//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

Console.WriteLine("введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0; // количество цифр в числе

while (a > 0)
{
    a = a/10;
    count++;
}
Console.WriteLine("количество цифр = " + count);

//второе решение

/*int numberFirst = GetNumber("Введите  число");
string x1 = Convert.ToString(numberFirst);
int lenNumber = x1.Length;
Console.WriteLine($"Количество цифр в числе равно {lenNumber}");*/
