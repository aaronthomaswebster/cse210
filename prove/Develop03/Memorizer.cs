using System;
class Memorizer
{
    private String _label;
    private String _info;

    private List<int> _visibleWords;
    public Memorizer(String label, String info)
    {
        _label = label;
        _info = info;
        _visibleWords = new List<int>();
        for(int i = 0; i < _info.Split(' ').Length; i++){
             _visibleWords.Add(i);
        }
    }

    public void Memorize(){        
        String input = "";
        bool allHidden = false;
        while(!input.Equals("quit") && !allHidden){
            Console.Clear();
            Display();
            allHidden = AllWordsHidden();
            HideWords();
            Console.WriteLine();
            Console.WriteLine("Press enter to hide words or type 'quit' to quit");
            input = Console.ReadLine();
        }
    }

    private void HideWords(){
        Random rnd = new Random();
        int numberOfWordsToHide = 3;
        if(_visibleWords.Count < numberOfWordsToHide){
            numberOfWordsToHide = _visibleWords.Count;
        }
        for(int i = 0; i < numberOfWordsToHide; i++){
            int index = rnd.Next(0, _visibleWords.Count);
            _visibleWords.RemoveAt(index);
        }
    }

    private void Display(){
        Console.Write(_label + " | ");
        String[] words = _info.Split(' ');
        for(int i = 0; i < words.Length; i++){
            if(_visibleWords.Contains(i)){
                Console.Write(words[i] + " ");
            }else{
                Console.Write(string.Concat(Enumerable.Repeat("_", words[i].Length)) + " ");
            }
        }
        Console.WriteLine();
    }

    private bool AllWordsHidden(){
        return _visibleWords.Count == 0;
    }

}