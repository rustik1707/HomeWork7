//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int Getnumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
    
        else
        {
            Console.WriteLine("ввели не число");
        }
    }
    return result;
}

int[,]Getmatrix(int m, int n)
{
    int[,]matrix = new int[m,n];
    Random rnd = new Random();
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0,11);
        }
    
     }

    return matrix;

}

void Printmatrix(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
     Console.WriteLine();   

    }

}


double[]Arifm(int[,]matrix)
{
int number = matrix.GetLength(1);
double[] result = new double[number];

    for (int i = 0; i < result.Length; i++)
    {
    for (int n = 0; n < matrix.GetLength(1); n++)
    {
        double sum = 0;
        for (int m = 0; m < matrix.GetLength(0); m++)
        {
            sum = sum + matrix[m,n]; 
        }
      result[i] = sum/matrix.GetLength(0);
    }
        
    }
    return result;
}

void PrintArray(double[]array)
{

    for (int i = 0; i < array.Length; i++)
    {
       Console.Write($"{array[i]} "); 
    }
    Console.WriteLine();
}




int m = Getnumber("введите количество строк");
int n = Getnumber("введите количество столбцов");
int[,]matrix = Getmatrix(m,n);
Printmatrix(matrix);
double[]arifm = Arifm(matrix);
Console.WriteLine();

PrintArray(arifm);
