/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.*/

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
            Console.WriteLine("ввели некорректную команду");
        }
        
    }
    return result;
}


double[,] Getmatix(int m, int n)
{
    double[,]array = new double[m,n];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(0,11)+rnd.NextDouble();
;
;
;
        }
    }

    return array;
}

void Printmatrix(double[,]array)
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

int m = Getnumber("введите число строк");
int n = Getnumber("введите число столбцов");

double[,]array = Getmatix(m,n);
Printmatrix(array);