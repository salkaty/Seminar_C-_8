// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
//  с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 21);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}
void SumRows(int[,] array, int[] sum)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
            int l=i;
       
            int rowSum = 0;
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    rowSum = rowSum + array[i, j];
                    
            }
            sum[l]=rowSum;
            
    }
}

void PrintSum(int[] sum, int size)
{
    foreach (var item in sum)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

string GetNumRow(int[] sum, int size)
{
    int minRowSum=sum[0];
    int numRow=0;
for (int i = 1; i < size; i++)
{
    if (sum[i]<minRowSum)
    {
      minRowSum=sum[i];
        numRow=i;
    }
}
return $"Строка {numRow} - это строка с минимальной суммой элементов    ";
}



Console.Clear();
System.Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[size, size];
FillArray(array);
PrintArray(array);
int[] sum = new int[size];
SumRows(array, sum);
System.Console.WriteLine();
PrintSum(sum, size);
string message=GetNumRow(sum,size);
Console.WriteLine(message);
System.Console.WriteLine();