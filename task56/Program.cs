// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] array = new int[4, 4];
CraeteArray(array);
void CraeteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
PrintArray(array);
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
// нашла сумму элементов в строке (как мне кажется)
for(int i=0; i < array.GetLength(1); i++){
  int sum=0;
  for(int j=0; j < array.GetLength(0) ; j++) 
  {
   sum += (sum + array[i, j]); 
  }
}
// надо ввести локальную переменную,чтобы сравнить суммы всех строк, и запомнить тогда номер строки с нименьшей суммой, но ничего не получилось
   


