// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
//Заполнение двумерного массива
double[,] FillMatrix(int rows, int cols)
{
    double[,] matr = new double[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.NextDouble() * 10;
        }
    }
    return matr;
}

void PrintMartix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(Math.Round(matr[i, j], 1) + "\t");
        }
        System.Console.WriteLine();
    }

}
double[,] matrix = FillMatrix(3, 4);
System.Console.WriteLine();
PrintMartix(matrix);


