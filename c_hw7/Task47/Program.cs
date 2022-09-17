// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами

Console.WriteLine("Введите два положительных числа, задающих размер матрицы: ");
int m= Convert.ToInt32(Console.ReadLine());
int n= Convert.ToInt32(Console.ReadLine());
double[,] matr = new double[m, n];

void FillArray(double[,] matr)
{
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
          matr[i,j] = random.Next(-5,6) + random.NextDouble();
        }
    }
}

void PrintArray(double[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]}  ");
    }
  Console.WriteLine();  
}
Console.WriteLine();  
}

FillArray(matr);
PrintArray(matr);
