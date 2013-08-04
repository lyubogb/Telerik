// 06.
// * Write a class Matrix, to holds a matrix of integers. 
//   Overload the operators for adding, subtracting and multiplying of matrices, 
//   indexer for accessing the matrix content and ToString().
//
//   Напишете един клас Матрикс който да съдържа матрица от цели числа
//   Предефинирайте операторите за събиране, изваждане и умножение на матрици,
//   индекса за достъп до матрицата и метода ToString()
//
//   Използван е основно кодът от WorkShop-а на Владислав Карамфилов

using System;

class MatrixUI
{
    static void Main()
    {
        Matrix matrix1 = new Matrix(2, 3);
        matrix1[0, 0] = 1;
        matrix1[0, 1] = -1;
        matrix1[0, 2] = 1;
        matrix1[1, 0] = 0;
        matrix1[1, 1] = 2;
        matrix1[1, 2] = -1;

        Matrix matrix2 = new Matrix(3, 2);
        matrix2[0, 0] = -2;
        matrix2[0, 1] = 1;
        matrix2[1, 0] = 3;
        matrix2[1, 1] = 2;
        matrix2[2, 0] = 4;
        matrix2[2, 1] = 5;

        Matrix sum = matrix1 + matrix2;
        Console.WriteLine("matrix1 + matrix2 = \n" + sum.ToString());
        Console.WriteLine();
        sum = matrix1 - matrix2;
        Console.WriteLine("matrix1 - matrix2 = \n" + sum.ToString());
        Console.WriteLine();       
    }

}