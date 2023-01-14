using System;

class PromptGenerator
{
    private List<String> _prompts = new List<String>();
    private String _promptFileName = "prompts.txt";

    public PromptGenerator(){
        loadPrompts();
    }

    public PromptGenerator(string promptFileName){
        _promptFileName = promptFileName;
        loadPrompts();
    }

    private void loadPrompts(){
        using (StreamReader sr = new StreamReader(_promptFileName))
        {
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                _prompts.Add(line);
            }
        }
    }


    public String GetRandomPrompt(){
        int randomIndex = new Random().Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }
}