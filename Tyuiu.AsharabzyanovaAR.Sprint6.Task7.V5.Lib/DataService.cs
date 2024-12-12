using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task7.V5.Lib
{
    public class DataService : ISprint6Task7V5
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            
            for (int j = 0; j < rows; j++)
            {
                if (matrix[j, 9] < 2)
                {
                    matrix[j, 9] = 2; 
                }
            }
            return matrix;
        }
    }
}
