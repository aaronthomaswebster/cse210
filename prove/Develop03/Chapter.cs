using System;

class Chapter
{
    private int _chapterNumber;
    private List<Verse> _verses;

    public Chapter(int chapterNumber){
        _chapterNumber = chapterNumber;
        _verses = new List<Verse>();
    }

    public void AddVerse(Verse verse){
        _verses.Add(verse);
    }

    public int GetChapterNumber(){
        return _chapterNumber;
    }

    public Verse GetVerse(int verseNumber){
        Verse v =  _verses.Find(x => x.GetVerseNumber().Equals(verseNumber));
        return v;
    }

    public int GetNumberOfVerses(){
        return _verses.Count;
    }
}