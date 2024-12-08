using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task3.V28.Lib
{
    public class DataService : ISprint6Task3V28
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j]%2==0 && i==3)
                    {
                        matrix[i,j]=0;

                    }
                }
            }
            return matrix;
        }
    }
}
