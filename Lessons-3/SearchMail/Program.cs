string pathToFileData = Path.Combine(Directory.GetCurrentDirectory(), "data.txt");

if (File.Exists(pathToFileData))
{
    string[] data = File.ReadAllLines(pathToFileData);

    for (int i = 0; i < data.Length; i++)
    {
        string temp = data[i];
        SearchMail(ref temp);
        data[i] = temp;
    }

    File.WriteAllLines(Path.Combine(Directory.GetCurrentDirectory(), "eMails.txt"), data); 
}

void SearchMail(ref string line)
{
    int index = 0;
    int length = line.Length;
    for (int i = 0; i < length; i++)
    {
        if (line[i] == '&')
        {
            index = i;
            break;
        }
    }
    line = line.Substring(index + 2);
}
