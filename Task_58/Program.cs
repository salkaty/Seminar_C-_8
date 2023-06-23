// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
//  произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray(int[,] matrixA, int[,] matrixB, int[,] matrixC)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
        for (int j = 0; j < matrixA.GetLength(1); j++)
            matrixA[i, j] = new Random().Next(-10, 11);
    for (int i = 0; i < matrixB.GetLength(0); i++)
        for (int j = 0; j < matrixB.GetLength(1); j++)
            matrixB[i, j] = new Random().Next(-10, 11);
    // matrixA[0, 0] = 2; контрольные матрицы для проверки
    // matrixA[0, 1] = 4;
    // matrixA[1, 0] = 3;
    // matrixA[1, 1] = 2;

    // matrixB[0, 0] = 3;
    // matrixB[0, 1] = 4;
    // matrixB[1, 0] = 3;
    // matrixB[1, 1] = 3;
    for (int i = 0; i < matrixC.GetLength(0); i++)
        for (int j = 0; j < matrixC.GetLength(1); j++)

            matrixC[i, j] = matrixA[i, 0] * matrixB[0, j] + matrixA[i, 1] * matrixB[1, j];
}

void PrintArray(int[,] matrixA, int[,] matrixB)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
            Console.Write($"{matrixA[i, j],3}    ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine("Вторая матрица");
    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
            Console.Write($"{matrixB[i, j],3}    ");
        System.Console.WriteLine();
    }

}

void PrintArrayResalt(int[,] matrixC)
{
    System.Console.WriteLine("Результирующая матрица");
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
            Console.Write($"{matrixC[i, j],3}    ");
        System.Console.WriteLine();
    }
}


Console.Clear();
System.Console.WriteLine("Первая матрица");
int[,] matrixA = new int[2, 2];
int[,] matrixB = new int[2, 2];
int[,] matrixC = new int[2, 2];
FillArray(matrixA, matrixB, matrixC);
PrintArray(matrixA, matrixB);
PrintArrayResalt(matrixC);


