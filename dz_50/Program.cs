// Задача 50. Напишите программу, которая на вход принимает число, 
// возвращает индексы этого элемента в двумерном массиве или же указание, что такого числа нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillMatrix(int rows, int cols)
{
    int[,] matr = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 100);
        }
    }
    return matr;
}

void PrintMartix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}

void CheckMatrixNumber(int[,] matr, int number)
{
    bool find_number = false;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (number == matr[i, j])
            {
                find_number = true;
                break;
            }     
        }
    }
    if(find_number) System.Console.WriteLine("Такое число есть");
    else System.Console.WriteLine("Такого числа нет");
}

int[,] matrix = FillMatrix(4, 3);
System.Console.WriteLine();
PrintMartix(matrix);
System.Console.WriteLine("Введите Число: ");
int number = Convert.ToInt32(Console.ReadLine());
CheckMatrixNumber(matrix, number);

