using System.ComponentModel.DataAnnotations;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AsharabzyanovaAR.Sprint6.Task6.V9.Lib
{
    public class DataService : ISprint6Task6V9
    {
        public string CollectTextFromFile(string str, string path)
        {
            string result = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;


                while ((line = reader.ReadLine()) != null)
                {

                    string[] fragments = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);


                    if (fragments.Length > 0)
                    {
                        result += fragments[^1] + " ";
                    }
                }
            }
            result = result.Trim();
            return result;
        }
    }
}
