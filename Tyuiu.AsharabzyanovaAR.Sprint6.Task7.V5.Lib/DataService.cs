using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task7.V5.Lib
{
    public class DataService : ISprint6Task7V5
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0) + 1;
            int columns = matrix.Length / rows;
            int xCol = 2;
            for (int r = 0; r < rows; r++) 
            {
                for (int c = xCol; c <= xCol; c++) 
                {
                    if (matrix[r, c]< 2&&columns==10)
                    {
                        matrix[r, c] = 2;

                    }
                }
            }
            return matrix;
        }
    }
}
