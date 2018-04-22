using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixes
{
    public class SquareMatrix<T>
    {
        public delegate void ChangeElementHandler(object sender, EventArgs e);
        public event ChangeElementHandler ElementChanged;
        public int Order { get; set; } 
        public T[,] Matrix
        {
            get { return Matrix;}
            set { Matrix = value; }
        }
        public SquareMatrix(int orderofmatrix)
        {
            Matrix = new T [orderofmatrix, orderofmatrix];
            Order = orderofmatrix;
        }

        public virtual void Fill()
        {
            for (int i = 0; i < Order; i++)
                for (int j = 0; j <Order; j++)
                {
                    Random rnd = new Random();
                    object temp = rnd;
                    Matrix[i, j] = (T)temp;
                }
        }
        public virtual void Changeelement(int row, int column, T newelement)
        {
            Matrix[row, column] = newelement;
            if (ElementChanged != null)
            {
                string tmp = $"Element[{row}{column}] has changed";
                ElementChanged(this, new EventArgs(tmp,row,column));
            }
        }
       
    }
    public class SymmetricMatrix<T>:SquareMatrix<T>
    {
        public SymmetricMatrix(int orderofmatrix):base(orderofmatrix)
        {
           
        }
        public override void Fill()
        {
            for (int i = 0; i < Order; i++)
                for (int j = 0; j < i; j++)
                {
                    Random rnd = new Random();
                    object temp = rnd;
                    Matrix[i, j] = (T)temp;
                    Matrix[i, j] = Matrix[j, i];
                }
        }
        public override void Changeelement(int row, int column, T newelement)
        {
            Matrix[row, column] = newelement;
            Matrix[column, row] = newelement;
        }
    }
    public class DiagonalMatrix<T> : SquareMatrix<T>
    {
        public DiagonalMatrix(int orderofmatrix) : base(orderofmatrix)
        {

        }
        public override void Fill()
        {
            for (int i = 0; i < Order; i++)
                for (int j = 0; j < i; j++)
                {
                    if (i != j) Matrix[i, j] = default(T);
                    else
                    {
                        Random rnd = new Random();
                        object temp = rnd;
                        Matrix[i, j] = (T)temp;
                        Matrix[i, j] = Matrix[j, i];
                    }
                }
        }
        public override void Changeelement(int row, int column, T newelement)
        {
            if (row != column) throw new Exception("Forbidden operation for diagonal matrix");
            else Matrix[row, column] = newelement;
        }
    }
    public class EventArgs
    {
        public string Message { get; }
        int Row { get; }
        int Column { get; }
        public EventArgs(string message, int row, int column)
        {
            Message = message;
            Row = row;
            Column = column;
        }
    }
    /// <summary>
    /// Program class saves the handler for all events
    /// </summary>
    static class Program
    {
         public static void Show_Message(object sender, EventArgs e)
    {
        Console.WriteLine(e.Message);
    }
}
    

}
