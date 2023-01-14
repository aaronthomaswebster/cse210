using System;

class Journal
{
    private List<Entry> _entries;

    public Journal(){
        _entries = new List<Entry>();
    }

    public Journal(String journalString){
        _entries = new List<Entry>();
        String[] entryStrings = journalString.Split("~||~");
        foreach(String entryString in entryStrings){
            Entry entry = new Entry(entryString);
            _entries.Add(entry);
        }
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

    public String Save(){
        String journalString = "";
        foreach(Entry entry in _entries){
            journalString += entry.Save() +"~||~";
        }
        return journalString;
    }
}