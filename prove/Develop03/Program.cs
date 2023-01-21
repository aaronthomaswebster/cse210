using System;

class Program
{
    static void Main(string[] args)
    {
        Menu homeMenu = new Menu(
            "Scripture Memorizer", 
            "Welcome, how would you like to slect your Scripture to memorize?",
            new List<String>{"Enter Scripture Manually", "Get Specific Scripture", "Get Random Scripture"}
        );
        int choice = homeMenu.Display();
        
        string lable = "";
        string text = "";

        switch(choice){
            case 1:
                Console.Clear();
                Console.WriteLine("Manual Scriptuer Entry ");
                Console.Write("Enter Reference: ");
                lable = Console.ReadLine();
                Console.Write("Enter the text of your verse: ");
                text = Console.ReadLine();
                break;
            case 2:
                Scripture s = Scriptures.GetScripture();
                lable = s.GetReference();
                text = s.GetText();
                break;
            case 3:
                Scripture s2 = Scriptures.GetRandomScripture();
                lable = s2.GetReference();
                text = s2.GetText();
                break;
            default:
                return;
        }
        Memorizer memorizer = new Memorizer(lable, text);
        memorizer.Memorize();
    }
    
}