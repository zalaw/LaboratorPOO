using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        private int[,] data;
        private static int maxDigits;

        public Matrix(int rows, int cols)
        {
            data = new int[rows, cols];
        }

        public Matrix(int n) : this(n, n) { }

        public void RandomInit(int maxValue)
        {
            Random rnd = new Random();
            int maxNumber = 0;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = rnd.Next(maxValue) + 1;
                    if (data[i, j] > maxNumber)
                    {
                        maxNumber = data[i, j];
                    }
                }
            }

            int maxDigistPlaceholder = 0;
            while (maxNumber != 0)
            {
                maxNumber = maxNumber / 10;
                maxDigistPlaceholder++;
            }
            maxDigits = maxDigistPlaceholder;
        }

        public int Rows
        {
            get
            {
                return data.GetLength(0);
            }
        }

        public int Cols
        {
            get
            {
                return data.GetLength(1);
            }
        }

        public static Matrix operator*(Matrix a, Matrix b)
        {
            if (a.Cols != b.Rows)
            {
                throw new ImpossibleMatrixOperationException();
            }
            
            Matrix c = new Matrix(a.Rows, b.Cols);
            int maxNumber = 0;

            for (int i = 0; i < c.Rows; i++)
            {
                
                for (int j = 0; j < c.Cols; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < a.Cols; k++)
                    {
                        sum += a[i, k] * b[k, j];
                    }
                    if (sum > maxNumber)
                    {
                        maxNumber = sum;
                    }
                    c[i, j] = sum;
                }
            }

            int maxDigistPlaceholder = 0;
            while (maxNumber != 0)
            {
                maxNumber = maxNumber / 10;
                maxDigistPlaceholder++;
            }
            maxDigits = maxDigistPlaceholder;

            return c;
        }

        public int this[int i, int j]
        {
            get
            {
                return data[i, j];
            }
            set
            {
                data[i, j] = value;
            }
        }

        public Matrix Transpose()
        {
            Matrix t = new Matrix(data.GetLength(1), data.GetLength(0));

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    t[j, i] = data[i, j];
                }
            }

            return t;
        }

        public static bool operator==(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows && a.Cols != b.Cols)
            {
                return false;
            }
            
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    if (a[i, j] != b[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator!=(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows && a.Cols != b.Cols)
            {
                return true;
            }

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    if (a[i, j] != b[i, j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string digits = "{0, ";
            digits += maxDigits + "}";

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    sb.AppendFormat(digits, data[i, j]);
                    sb.Append(" ");
                }
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
