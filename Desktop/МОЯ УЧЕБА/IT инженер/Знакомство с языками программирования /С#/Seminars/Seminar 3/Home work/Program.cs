/* 
// Задача 19.Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

using System;
namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер для проверки : ");
            int number = int.Parse(Console.ReadLine());
            int remineder, sum = 0;
            int temp = number;
            while (number > 0)
            {
             
                remineder = number % 10;
               
                sum = (sum * 10) + remineder;
               
                number = number / 10; 
            }
            if (temp == sum)
            {
                Console.WriteLine($"Номер {temp} является палиндромом.");
            }
            else
            {
                Console.WriteLine($"Номер {temp} НЕ является палиндромом");
            }
            Console.ReadKey();
        }
    }
}


/*
//Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

double FindDistance(double x1, double y1, double x2, double y2, double z1, double z2)
{
    return Math.Sqrt 
    ((x2 - x1) *(x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}
Console.WriteLine("Введите точку 1  ");
double xA = Convert.ToInt32(Console.ReadLine());
double yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку 2  ");
double xB = Convert.ToInt32(Console.ReadLine());
double yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку 3  ");
double z1B = Convert.ToInt32(Console.ReadLine());
double z2B = Convert.ToInt32(Console.ReadLine());

double dist3D = FindDistance(xA, yB, xB, yB, z1B, z2B);
Console.WriteLine($" Дистанция составит {dist3D}  ");



/*
/ Задача 23. Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

void Cube (int n)
{
    int i = 1;
    while (i <= n)
    {
        if (i == n) Console.Write ($" {i * i * i}. ");
        else Console.Write ($" {i * i * i}, ");
        i ++;
    }
}

Console.WriteLine("Введите число:   ");
int number = Convert.ToInt32(Console.ReadLine());
Cube (number);

*/