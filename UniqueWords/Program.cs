
using UniqueWords;

UniqueWordService wordService = new UniqueWordService();

var Words = await wordService.FinduniqueWordFromFilesAsync(GetPaths());

Words.ToList().ForEach(x => Console.WriteLine(x));


//Возращает все файлы из директории Data
static List<string> GetPaths() 
{
    string basePath = Directory.GetCurrentDirectory() + "\\Data";

    return Directory.GetFiles(basePath).ToList();
}