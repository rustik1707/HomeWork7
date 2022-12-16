 /*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:*/

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



int m =Getnumber("введите количество строк");
int n =Getnumber("введите количество столбцов");
int[,]matrix = Getmatrix(m,n);
Printmatrix(matrix);
Console.WriteLine("Введите координаты");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 int result = 0;
 if (a<=m && b<=n)
 { 
    result = matrix[a,b];
    Console.WriteLine($"значение искомого элемента равна:{result}");
 }
 else
 {
  Console.WriteLine("такого значения нет");
 }

 