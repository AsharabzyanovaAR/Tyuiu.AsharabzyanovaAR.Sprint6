using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task5.V21.Lib
{
    public class DataService : ISprint6Task5V21
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null) len++;
            }
            double[] valueArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    valueArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }
            valueArray = valueArray.Where(val => val%3==0).ToArray();
            return valueArray;

        }
    }
}
