// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите два положительных числа, задающих размер матрицы: ");
int m= Convert.ToInt32(Console.ReadLine());
int n= Convert.ToInt32(Console.ReadLine());

int[,] matr = new int[m, n];

void FillArray(int[,] matr)
{
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
          matr[i,j] = random.Next(-5,6);
        }
    }
}

void PrintArray(int[,] matr)
{
Console.WriteLine("Cгенерирована матрица:"); 
for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
    Console.WriteLine();
    }
Console.WriteLine("_______________________");  
}

FillArray(matr);
PrintArray(matr);

void AverageForColumn()
{
double[] str = new double[n];
int z = 0;
for (int j = 0; j < n; j++)
{
    str[z]=0;
    for (int i = 0; i < m; i++)
    {
    str[z] = str[z] + matr[i, j];
    }
    Console.Write($"{str[z]/m}  ");
    z++;
}
return;
}
AverageForColumn();