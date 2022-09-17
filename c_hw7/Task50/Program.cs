// Задача 50. программу, 
// которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

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
Console.WriteLine();  
}

FillArray(matr);
PrintArray(matr);

Console.WriteLine("Введите позицию элемента, который надо вывести: ");
int p= Convert.ToInt32(Console.ReadLine());

void FindElement()
{
    int q= m*n;
if (p < q) 
{
            int[] str = new int[q];
            int z = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                str[z] = matr[i, j];
                // Console.Write($"{str[z]}  ");
                z++;
                }
            }

    Console.Write($"{p} -элемент массива = {str[p]}");
}

else Console.Write(" Такого элемента в заданной матрице нет ");
return;
}
FindElement();