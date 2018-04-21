using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixes
{
    public class SquareMatrix<T>
    {
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
    }

}
