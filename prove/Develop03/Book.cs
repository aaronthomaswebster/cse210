using System;

class Book
{
    private String _name;
    private List<Chapter> _chapters;

    public Book(string name){
        _name = name;
        _chapters = new List<Chapter>();
    }

    public void AddChapter(Chapter chapter){
        _chapters.Add(chapter);
    }

    public Chapter GetChapter(int chapterNumber){
        Chapter c =  _chapters.Find(x => x.GetChapterNumber().Equals(chapterNumber));
        return c;
    }

    public String GetName(){
        return _name;
    }

    public int GetNumberOfChapters(){
        return _chapters.Count;
    }
}