using System;

class Journal
{
    private List<Entry> _entries;

    public Journal(){
        _entries = new List<Entry>();
    }

    
    
    public void AddEntry(PromptGenerator promptGenerator){
        if(promptGenerator == null){
            throw new ArgumentNullException("promptGenerator");
        }
        DateTime thisDay = DateTime.Today;
        String prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        String response = Console.ReadLine();
        Entry entry = new Entry(thisDay.ToString("D"), prompt, response);
        _entries.Add(entry);
    }

    public void Display(){
        foreach(Entry entry in _entries){
            entry.Display();
        }
    }

    public void Save(String fileName){
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            foreach(Entry entry in _entries){
                sw.WriteLine(entry.Save());
            }
        }
    }

    public void Load(String fileName){
        _entries.Clear();
        using (StreamReader sr = new StreamReader(fileName))
        {
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                Entry entry = new Entry(line);
                _entries.Add(entry);
            }
        }
    }
}