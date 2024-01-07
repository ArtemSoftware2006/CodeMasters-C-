namespace UniqueWords
{
    class UniqueWordService 
    {

        public async Task<HashSet<string>> FinduniqueWordFromFilesAsync(List<string> paths) 
        {
            HashSet<string> wordsSet = new HashSet<string>();
            char[] charsToRemove = new char[] { '@', '-', ',', '.', '?', '!', ':', ';', '\"' };

            foreach (var path in paths)
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    string line;
                    while((line = await streamReader.ReadLineAsync()) != null) 
                    {
                        line = line.Trim();
                        line = String.Concat(line.Split(charsToRemove));
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