

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
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
        }
        Console.WriteLine
        ("Количество четных чисел в массиве:  "  + even);                         
    }
}
*/

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
//Найдите разницу между максимальным и минимальным элементов массива.