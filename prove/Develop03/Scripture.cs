using System;
class Scripture
{
    private String _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse = 0;
    private List<Verse> _verses;
    public Scripture(String book, int chapter, Verse verse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse.GetVerseNumber();
        _verses = new List<Verse>();
        _verses.Add(verse);
    }

    public Scripture( String book, int chapter, List<Verse> verses)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verses[0].GetVerseNumber();
        _lastVerse = verses[verses.Count - 1].GetVerseNumber();
        _verses = verses;
    }

    public String GetReference(){
        if(_lastVerse == 0){
            return  _book + " " + _chapter + ":" + _firstVerse;
        }
        return _book + " " + _chapter + ":" + _firstVerse + "-" + _lastVerse;
    }

    public String GetText(){
        String text = "";
        foreach(Verse v in _verses){
            text += v.GetVerseText() + " ";
        }
        return text.Trim();
    }

    public void Display(){
        Console.Write(GetReference()+ " | ");
        Console.WriteLine(GetText());
    }

}