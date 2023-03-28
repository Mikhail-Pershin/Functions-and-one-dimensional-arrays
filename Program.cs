// // Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2


// Console.Write($"Введите размер массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = GetRandomArray(num);
// Console.WriteLine($"Массив случайныx положительныx трёхзначныx числел: ");
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"Kоличество чётных чисел в массиве -> {CountEvenNumbersArray(array)}");

// // -------------------------------Общий метод-------------------------------------------

// int[] GetRandomArray(int size)
// {
//   int[] result = new int[size];
//   for (int i = 0; i < size; i++)
//   {
//     result[i] = new Random().Next(100, 1000);
//   }
//   return result;
// }

// // -------------------------------Общий метод-------------------------------------------

// int CountEvenNumbersArray(int[] array)
// {
//   int count = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] % 2 == 0)
//     {
//       count++;
//     }
//   }
//   return count;
// }



// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.Write($"Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(num);
Console.WriteLine($"Одномерный массив, заполненный случайными числами: ");
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных индексах -> {SumNumbersOddIndexes(array)}");

// -------------------------------Общий метод-------------------------------------------

int[] GetArray(int size)
{
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(-10, 20);
  }
  return result;


  // -------------------------------Общий метод-------------------------------------------

}
int SumNumbersOddIndexes(int[] array)
{
  int sum = 0;
  for (int i = 1; i < array.Length; i += 2)
  {
    sum += array[i];
  }
  return sum;
}