// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void FillArray(int[] array, int number)
{
    for (int i = 1; i < array.Length; i++)
    {
        array[0] = number;
        array[i] = array[i - 1] + 1;
    }
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}
void FillArrayB(int[,] arrayB, int[] array)
{
    for (int i = 0; i < arrayB.GetLength(0); i++)
    //arrayB[0, 3] = array[3];
    //arrayB[i, 3] = arrayB[i, 3]+1;
        for (int j = 0; j < arrayB.GetLength(1)-1; j++)
            arrayB[i, j] = array[j];//нулевая строка
      int numl=3;      
    for (int i = 0; i < arrayB.GetLength(0); i++)
        arrayB[i, 3] = array[numl]+i;// 0;4 крайний столбец 
     for (int i = 1; i < arrayB.GetLength(0); i++)   
    for (int j = 0; j < arrayB.GetLength(1)-1; j++)
            arrayB[i, j] = array[j+11];
    for (int i = 3; i < arrayB.GetLength(0); i++) //третья строка  
    for (int j = 0; j < arrayB.GetLength(1)-1; j++)
            arrayB[i, j] = array[9-j];
      arrayB[2,0] = array[10];    
      arrayB[2,1]=array[15];
      arrayB[2,2]=array[14];
   
}       
    




void PrintArrayB(int[,] arrayB)
{
    for (int i = 0; i < arrayB.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
            Console.Write($"{arrayB[i, j],3}    ");
        System.Console.WriteLine();
    }
}



Console.Clear();
System.Console.WriteLine("Введите число, с которого будет начинаться выстраиваться массив по спирали");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[16];
FillArray(array, number);
PrintArray(array);
int[,] arrayB = new int[4, 4];
FillArrayB(arrayB, array);
PrintArrayB(arrayB);