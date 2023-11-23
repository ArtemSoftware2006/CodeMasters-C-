
using UniqueWords;

UniqueWordService wordService = new UniqueWordService();

List<string> paths = new()
{
    Directory.GetCurrentDirectory() + "\\Data\\Беда_одна_не_ходит.txt",
    Directory.GetCurrentDirectory() + "\\Data\\Начало.txt",
    Directory.GetCurrentDirectory() + "\\Data\\Tect.txt",
    Directory.GetCurrentDirectory() + "\\Data\\Хэппи_Энд.txt"
};

var Words = await wordService.FinduniqueWordFromFilesAsync(paths);

Words.ToList().ForEach(x => Console.WriteLine(x));