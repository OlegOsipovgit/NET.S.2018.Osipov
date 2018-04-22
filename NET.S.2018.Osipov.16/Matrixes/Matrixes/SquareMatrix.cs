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
            get { return Matrix; }
            set { Matrix = value; }
        }
        public SquareMatrix(int orderofmatrix)
        {
            Matrix = new T[orderofmatrix, orderofmatrix];
            Order = orderofmatrix;
        }

        public virtual void Fill()
        {
            for (int i = 0; i < Order; i++)
                for (int j = 0; j < Order; j++)
                {
                    Random rnd = new Random();
                    object temp = rnd;
                    Matrix[i, j] = (T)temp;
                }
        }
        public void Show_Message(object sender, EventArgs e)
        {
            Console.WriteLine(e.Message);
        }
        public virtual void Changeelement(int row, int column, T newelement)
        {
            Matrix[row, column] = newelement;
            ElementChanged += Show_Message;
            if (ElementChanged != null)
            {
                string tmp = $"Element[{row}{column}] has changed";
                Callevent(row,column,newelement,tmp);
            }
            ElementChanged -= Show_Message;
        }
        /// <summary>
        /// for calling of ElementChanged event in inheritable classes, becouse this event isnt called in inheritable classes
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="newelement"></param>
        /// <param name="tmp"></param>
        public void Callevent(int row, int column, T newelement, string tmp )
        {
            ElementChanged(this, new EventArgs(tmp, row, column));
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
            ElementChanged += Show_Message;
            string tmp = $"Element[{row}{column}] and element[{column}{row}] has changed";
            Callevent(row, column, newelement, tmp);
            ElementChanged -= Show_Message;
                            
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
            ElementChanged += Show_Message;
            string tmp = $"Element[{row}{column}] has changed";
            Callevent(row, column, newelement, tmp);
            ElementChanged -= Show_Message;
        }
    }
    /// <summary>
    /// Contains all data of event. Some field of the object of this class can be send to the event handler(Message in our case). 
    /// </summary>
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
    
}
    

}
