using System;

class Program
{

    static void Main(string[] args)
    {

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();


        Console.WriteLine("Welcome to the Journal Program!");
        string option = "";
        while (option != "0"){
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Add an entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Load journal");
            Console.WriteLine("4. Save journal");
            Console.WriteLine("5. Update prompts");
            Console.WriteLine("0. Exit");
            Console.Write("> ");
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    journal.AddEntry(promptGenerator);
                    break;
                case "2":
                    // code block
                    journal.Display();
                    break;
                case "3":
                    Console.WriteLine("Enter the file name to load:");
                    Console.Write("> ");
                    string fileName = Console.ReadLine();
                    journal.Load(fileName);
                    break;
                case "4":
                    Console.WriteLine("Enter the file name to save:");
                    Console.Write("> ");
                    fileName = Console.ReadLine();
                    journal.Save(fileName);
                    break;
                case "5":
                    promptGenerator.Menu();
                    break;
            }

        }
        Console.WriteLine("Goodbye!");
    }

}