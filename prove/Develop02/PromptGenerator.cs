using System;

class PromptGenerator
{
    private List<String> _prompts = new List<String>();
    private String _promptFileName = "prompts.txt";

    public PromptGenerator()
    {
        loadPrompts();
    }

    public PromptGenerator(string promptFileName)
    {
        _promptFileName = promptFileName;
        loadPrompts();
    }

    private void loadPrompts()
    {
        _prompts.Clear();
        using (StreamReader sr = new StreamReader(_promptFileName))
        {
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                _prompts.Add(line);
            }
        }
    }

    private void savePrompts()
    {
        using (StreamWriter sw = new StreamWriter(_promptFileName))
        {
            foreach (String prompt in _prompts)
            {
                sw.WriteLine(prompt);
            }
        }
    }

    private void AddPrompt()
    {
        Console.WriteLine("Enter a new prompt:");
        Console.Write("> ");
        _prompts.Add(Console.ReadLine());
        savePrompts();
    }

    private void Display()
    {
        foreach (String prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }

    public String GetRandomPrompt()
    {
        int randomIndex = new Random().Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }

    public void Menu()
    {
        Console.WriteLine("Welcome to the Prompt Generator Menu!");
        Console.WriteLine("Please note, prompt files save automatically.");
        string option = "";
        while (option != "0")
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Add a prompt");
            Console.WriteLine("2. Display all prompts");
            Console.WriteLine("3. Load different prompt file");
            Console.WriteLine("4. Create new prompt file");
            Console.WriteLine("0. Exit");
            Console.Write("> ");
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    AddPrompt();
                    break;
                case "2":
                    Display();
                    break;
                case "3":
                    Console.WriteLine("Enter the file name to load:");
                    Console.Write("> ");
                    _promptFileName = Console.ReadLine();
                    loadPrompts();
                    break;
                case "4":
                    Console.WriteLine("Enter the file name to create:");
                    Console.Write("> ");
                    _prompts.Clear();
                    _promptFileName = Console.ReadLine();
                    savePrompts();
                    break;
            }

        }
    }
}