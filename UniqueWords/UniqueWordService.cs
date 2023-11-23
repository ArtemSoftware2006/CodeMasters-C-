namespace UniqueWords
{
    class UniqueWordService 
    {

        public async Task<HashSet<string>> FinduniqueWordFromFilesAsync(List<string> paths) 
        {
            HashSet<string> wordsSet = new HashSet<string>();
            List<char> charsToRemove = new List<char>() { '@', '-', ',', '.', '?', '!', ':', ';', '\"' };

            foreach (var path in paths)
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    string line;
                    while((line = await streamReader.ReadLineAsync()) != null) 
                    {
                        line = line.Trim();
                        line = String.Concat(line.Split(charsToRemove.ToArray()));
                        line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToList()
                            .ForEach(x => {
                                wordsSet.Add(x.ToLower());
                            });
                    }
                }
            }

            return wordsSet;
        }
    }
}