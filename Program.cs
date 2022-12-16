// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] CreateArray(int num, int min, int max){
//     int[] array = new int [num];
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(min, max);
//     return array;
// }

// void ShowArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]} ");
//     }
// }

// int Counter (int[] array){
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >=10 && array[i] <= 99)
//             count+=1;
//     }
//     return count;
// }

// int num = 112;
// int min = 5;
// int max = 754;
// int[] myarray = CreateArray(num, min, max);
// ShowArray(myarray);
// Console.WriteLine();
// Console.Write($"Количество элементов массива, значения которых лежат в отрезке [10,99]: {Counter(myarray)}");

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] CreateArray(int num, int min, int max)
// {
//     int[] array = new int[num];
//     for (int i = 0; i < num; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int EvenNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             count += 1;
//     }
//     return count;
// }

// int num = 20;
// int min = 100;
// int max = 1000;
// int[] myArray = CreateArray(num, min, max);
// PrintArray(myArray);
// Console.WriteLine();
// Console.Write($"В массиве {EvenNumbers(myArray)} четных чисел");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int[] CreateArray(int num, int min, int max)
// {
//     int[] array = new int[num];
//     for (int i = 0; i < num; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int Summ(int[] array)
// {
//     int summ = 0;
//     for (int i = 1; i < array.Length; i += 2)
//     {
//         summ = summ + array[i];
//     }
//     return summ;
// }

// int num = 10;
// int min = 0;
// int max = 50;

// int[] myArray = CreateArray(num, min, max);
// PrintArray(myArray);
// Console.WriteLine();
// Console.WriteLine($"сумма элементов на нечетных позициях равна {Summ(myArray)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] CreateArray(int num, int min, int max)
// {
//     double[] array = new double[num];
//     for (int i = 0; i < num; i++)
//     {
//         array[i] = Convert.ToDouble(new Random().Next(min, max));
       
//     }
//     return array;
// }

// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// double Min(double[] array)
// {
//     double min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (min > array[i])
//         {
//             min = array[i];
//         }
//     }

//     return min;
// }

// double Max(double[] array)
// {
//     double max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (max < array[i])
//         {
//             max = array[i];
//         }
//     }
//     return max;
// }


// double DifferenceMinMax(double Min, double Max)
// {
//     double difference = Max - Min;
//     return difference;
// }

// int num = 10;
// int min = 0;
// int max = 125;

// double[] myArray = CreateArray(num, min, max);
// PrintArray(myArray);
// Console.WriteLine();
// Console.WriteLine($"min = {Min(myArray)}");
// Console.WriteLine($"max = {Max(myArray)}");
// Console.WriteLine($"Разница между максимальным и минимальным значением массива равна {DifferenceMinMax(Min(myArray), Max(myArray))}");


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

 int[] CreateArray(int num, int min, int max){
      int[] array = new int[num];
      for(int i = 0; i < num; i++){
        array[i] = new Random().Next(min,max);
      }
      return array;   
    }
  
    void ShowArray(int[] array){
      for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
      }
    }


    int[] ResultArray(int[] array){  
      int number = array.Length/2;
      if(array.Length/2!=0){
        number = array.Length/2+1;
      }
      int[] result = new int[number];
      for(int i = 0; i < number; i++){
        result[i] = array[i]*array[array.Length-i-1];
        if(i == array.Length-i-1){
          result[i] = array[i];
        }
      }
      return result;
    }
    



  int num = 5;
  int min = -10;
  int max = 10;
  int[] myArray = CreateArray(num, min, max);
  ShowArray(myArray);
  Console.WriteLine();
  int[] result = ResultArray(myArray);
  ShowArray(result);