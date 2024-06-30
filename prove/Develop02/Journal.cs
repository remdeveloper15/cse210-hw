using System.IO;

class Journal 
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        string fileName = file;

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}, {entry._promptText}, {entry._entryText}");
            }
        }

    }

    public void LoadFromFile(string file)
    {
        string fileName = file;

        string [] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string [] parts = line.Split(",");string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];

            Entry entry = new Entry();

            entry._date = date;
            entry._promptText = promptText;
            entry._entryText = entryText;

            _entries.Add(entry);

        }
    }
}