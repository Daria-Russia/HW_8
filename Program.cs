//Task 54 Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//void NewMatrix(int[,] matrix)
//{
//    for (int i=0; i<matrix.GetLength(0); i++)
//    {
//        for (int j=0; j<matrix.GetLength(1); j++)
//        {
//            matrix[i,j] = new Random().Next(-10,11);
//            Console.Write(matrix[i,j]+" ");
//        }
//        Console.WriteLine();
//    }
//}

//void SortRow(int[,] matrix)
//{
//   for (int i =0; i<matrix.GetLength(0); i++)
//   {
//    for (int j =0; j<matrix.GetLength(1); j++)
//  {
//       for (int k =0; k<matrix.GetLength(1)-1; k++)
//       {
//           if (matrix[i,k] < matrix[i,k+1])
//            {
//                int temp = matrix[i, k+1];
//                matrix[i, k-1] = matrix[i,k];
//                matrix[i,k] = temp;
//            }
//        }
//        Console.Write(matrix[i,j]+" ");
//    }
//    Console.WriteLine();
//   }
//}
//Console.Write("Введите количество строк: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите количество столбцов: ");
//int m = Convert.ToInt32(Console.ReadLine());
//int[,] matrix = new int [n,m];
//Console.WriteLine("Начальная матрица: ");
//NewMatrix(matrix);
//Console.WriteLine("Конечная матрица: ");
//SortRow(matrix);

//Task 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//void NewMatrix(int[,] matrix)
//{
//    for (int i=0; i<matrix.GetLength(0); i++)
//    {
//        for (int j=0; j<matrix.GetLength(1); j++)
//        {
//            matrix[i,j] = new Random().Next(-10,11);
//            Console.Write(matrix[i,j]+" ");
//        }
//        Console.WriteLine();
//    }
//}
//void SortRow(int[,] matrix)
//{
//    int[] Sumrow = new int[matrix.GetLength(0)];
//   for (int i =0; i<matrix.GetLength(0); i++)
//   {
//    for (int j =0; j<matrix.GetLength(1); j++)
//    {
//       Sumrow[i]+= matrix[i,j];
//        
//    }
//   }
//   int temp = Sumrow[0];
//   int Numberrow = 0;
//   for (int i = 0; i< Sumrow.Length; i++)
//   {
//    if (Sumrow[i]<temp)
//    {
//        temp = Sumrow[i];
//        Numberrow = i+1;
//    }
//   }
//   Console.WriteLine("Минимальная сумма элементов в строке: " +Numberrow);
//   Console.WriteLine("Минимальная сумма элементов равна: " +temp);
//}
//Console.Write("Введите количество строк: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите количество столбцов: ");
//int m = Convert.ToInt32(Console.ReadLine());
//int[,] matrix = new int [n,m];
//Console.WriteLine("Начальная матрица: ");
//NewMatrix(matrix);
//SortRow(matrix);


//Task Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//void NewMatrix(int[,] matrix)
//{
//    for (int i=0; i<matrix.GetLength(0); i++)
//    {
//        for (int j=0; j<matrix.GetLength(1); j++)
//        {
//            matrix[i,j] = new Random().Next(-10,11);
//            Console.Write(matrix[i,j]+" ");
//        }
//        Console.WriteLine();
//    }
//}
//void ProductofNumbers(int[,] MatrixOne, int[,] MatrixTwo)
//{
//    int [,] ResultMatrix = new int[MatrixOne.GetLength(0), MatrixOne.GetLength(1)];
//    for (int i = 0; i<MatrixOne.GetLength(0); i++)
//    {
//        for (int j = 0; j<MatrixOne.GetLength(1); j++)
 //       {
//         ResultMatrix[i,j] = MatrixOne[i,j]*MatrixTwo[i,j];
//        Console.Write(ResultMatrix[i,j] + " ");
//        }
//        Console.WriteLine();
//    }
//}
//Console.Write("Введите количество строк: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите количество столбцов: ");
//int m = Convert.ToInt32(Console.ReadLine());
//int[,] MatrixOne = new int [n,m];
//int[,] MatrixTwo = new int [n,m];
//Console.WriteLine("Начальная матрица 1: ");
//NewMatrix(MatrixOne);
//Console.WriteLine("Начальная матрица 2: ");
//NewMatrix(MatrixTwo);
//Console.WriteLine("Произведение матриц: ");
//ProductofNumbers(MatrixOne, MatrixTwo);

//Task 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void NewMatrix(int[,,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            for (int k=0; k<matrix.GetLength(2); k++)
            matrix [i,j,k] = new Random().Next(-10,11);    
        }      
    }
}


void PrintMatrix(int[,,] MatrixOne)
{
     for (int i=0; i<MatrixOne.GetLength(0); i++)
    {
        for (int j=0; j<MatrixOne.GetLength(1); j++)
        {
            for (int k=0; k<MatrixOne.GetLength(2); k++)
            Console.WriteLine(MatrixOne[i,j,k] + "(" +i+","+j+","+k+")");   
        }      
    }
}
Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] MatrixOne = new int [x,y,z];
NewMatrix(MatrixOne);
PrintMatrix(MatrixOne);
