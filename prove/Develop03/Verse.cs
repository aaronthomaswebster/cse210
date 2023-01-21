using System;

class Verse
{
    private int _verseNumber;
    private String _verseText;

    public Verse(int verseNumber, string verseText){
        _verseNumber = verseNumber;
        _verseText = verseText;
    }

    public String GetVerse(){
        return $"{_verseNumber} {_verseText}";
    }

    public int GetVerseNumber(){
        return _verseNumber;
    }

    public String GetVerseText(){
        return _verseText;
    }


}