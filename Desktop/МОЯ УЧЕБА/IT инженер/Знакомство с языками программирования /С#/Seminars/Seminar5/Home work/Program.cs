
/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System;
 
public class GFG 
{
     
    public static void Main()
    {
      int [] arr = new int[8];
        int size = 8;
        for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100, 999);


    Console.WriteLine(); 

        int even = 0;
 
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr [i] % 2 == 0)
            
           even++;
        
        Console.WriteLine ($"Количество четных чисел в массиве {(arr [i])}:  "  + even);
        }                        
    }
}

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

using System;
 
public class GFG 
{
     
    public static void Main()
    {
      int [] arr = new int[8];
        int size = 8;
        for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100, 999);


    Console.WriteLine(); 

        int odd = 0;
 
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr [i] % 2 != 0)
            
           odd += arr[i];
        
        Console.WriteLine
        ($"Сумма нечетных чисел в массиве {(arr [i])}:  "  + odd);
        }                         
    }
}

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
/*
Console.WriteLine("Введите размер массива:");
int n = Convert.ToInt32(Console.ReadLine()); 
double [] arr  = new double [n];      
Random rnd = new Random();      
for (int i = 0; i < n; i++)
    { arr[i] = rnd.Next(-100, 100) + rnd.NextDouble ();  
    Console.Write($" {arr[i]} ");
}
double min = 0;
double max = 0;
foreach (int i in arr)  
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");
*/