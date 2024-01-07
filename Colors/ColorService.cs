using System.Text.RegularExpressions;

namespace Colors
{
    public class ColorService
    {
        public string ColorFilePath {get; set;}

        public ColorService(string colorFilePath)
        {
            this.ColorFilePath = colorFilePath;
        }

        public async Task TransformFile(string filePath)
        {
            string pattern = "";

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Файл для изменения по пути {filePath} не найден");
            }

            if (!File.Exists(ColorFilePath))
            {
                throw new FileNotFoundException($"Файл с цветами по пути {this.ColorFilePath} не найден");
            }

            Regex.Replace()
        }
    }
}