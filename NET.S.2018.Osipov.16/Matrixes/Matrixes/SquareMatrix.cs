using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixes
{
    #region Classes
    /// <summary>
    /// Square Matrix class(the base class)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SquareMatrix<T>
    {
        #region Public fields
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
        #endregion
        #region Methods
        /// <summary>
        /// Method of square matrix filling
        /// </summary>
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
        /// <summary>
        /// Event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Show_Message(object sender, EventArgs e)
        {
            Console.WriteLine(e.Message);
        }
        /// <summary>
        /// Method for change of some element of square matrix
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="newelement"></param>
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
        /// Method for calling of ElementChanged event in inheritable classes, becouse this event isnt called in inheritable classes
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="newelement"></param>
        /// <param name="tmp"></param>
        public void Callevent(int row, int column, T newelement, string tmp )
        {
            ElementChanged(this, new EventArgs(tmp, row, column));
        }
       /* public T[,] SumofMatrix<T>(T[,] matrix1, T[,] matrix2)
        {
            int order = matrix1.GetLength(0);
            T[,] resultMatrix = new T[order, order];
            if (Type.GetTypeCode(matrix1.GetType()) == TypeCode.String)
            {
                for (int i = 0; i < order; i++)
                    for (int j = 0; j < order; j++)
                        resultMatrix[i, j] = Concatination(matrix1[i, j], matrix2[i, j]);
             }
        }
        public string Concatination<T>(T a, T b)
        {
            return String.Concat(a, b);
        }*/
        #endregion
    }
    /// <summary>
    /// Class for symmetric matrix, the base class is SquareMatrix
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SymmetricMatrix<T>:SquareMatrix<T>
    {
        #region Public fields
        public SymmetricMatrix(int orderofmatrix):base(orderofmatrix)
        {
           
        }
        #endregion
        #region Methods
        /// <summary>
        /// Method of symmetric matrix filling
        /// </summary>
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
        /// <summary>
        ///Method for change of some element of symmetric matrix 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="newelement"></param>
        public override void Changeelement(int row, int column, T newelement)
        {
            Matrix[row, column] = newelement;
            Matrix[column, row] = newelement;
            ElementChanged += Show_Message;
            string tmp = $"Element[{row}{column}] and element[{column}{row}] has changed";
            Callevent(row, column, newelement, tmp);
            ElementChanged -= Show_Message;
                            
        }
        #endregion
    }
    /// <summary>
    /// Class for diagonal matrix, the base class is Square matrix.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DiagonalMatrix<T> : SquareMatrix<T>
    {
        #region Public fields
        public DiagonalMatrix(int orderofmatrix) : base(orderofmatrix)
        {

        }
        #endregion
        #region Methods
        /// <summary>
        /// Method for diagonal matrix filling
        /// </summary>
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
        /// <summary>
        /// Method for changing of some element of diagonal matrix
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="newelement"></param>
        public override void Changeelement(int row, int column, T newelement)
        {
            if (row != column) throw new Exception("Forbidden operation for diagonal matrix");
            else Matrix[row, column] = newelement;
            ElementChanged += Show_Message;
            string tmp = $"Element[{row}{column}] has changed";
            Callevent(row, column, newelement, tmp);
            ElementChanged -= Show_Message;
        }
        #endregion
    }
    /// <summary>
    /// Contains all data of event. Some field of the object of this class can be send to the event handler(Message in our case). 
    /// </summary>
    public class EventArgs
    {
        #region Public fields
        public string Message { get; }
        int Row { get; }
        int Column { get; }
        public EventArgs(string message, int row, int column)
        {
            Message = message;
            Row = row;
            Column = column;
        }
        #endregion
    }
    #endregion
}



