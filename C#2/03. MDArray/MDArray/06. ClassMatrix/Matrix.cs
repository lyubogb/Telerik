using System;

class Matrix
{
    private int[,] matrix;              // private ==> matrix може да буте използван само в класа matrix
    public Matrix(int rows, int cols)           //дефиниране на конструктор
    {
        this.matrix = new int[rows, cols];
    }
    public int Rows                     // public  ==> Rows (свойство) характеристика на обект от класа 
    {                                   //             описваща негово състояние или спесификация           
        get
        {
            return this.matrix.GetLength(0);
        }
    }
    public int Columns
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }
    public static Matrix operator +(Matrix first, Matrix seccond)    // Предефиниране на оператора за събиране
    {
        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] + seccond[row, col];
            }
        }
        return result;
    }
    public static Matrix operator -(Matrix first, Matrix seccond)    // Предефиниране на оператора за изваждане
    {
        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] - seccond[row, col];
            }
        }
        return result;
    }
    public int this[int row, int col]           // дефиниране на индексатора
    {
        get         // ще връща стойност
        {
            return this.matrix[row, col];
        }
        set         // ще задава стойност на текущият ред и текущата колона
        {
            this.matrix[row, col] = value;
        }
    }
    public override string ToString()           // ToString
    {
        string result = null;

        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Columns; col++)
            {
                result += matrix[row, col] + " ";
            }
            result += Environment.NewLine;
        }

        return result;
    }
}