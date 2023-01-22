using System;
static class Scriptures
{
    private static List<StandardWork> _standardWorks;
    static Scriptures()
    {
        _standardWorks = new List<StandardWork>();
        _standardWorks.Add(LoadScriptures("scriptures/ot.csv", "Old Testament"));
        _standardWorks.Add(LoadScriptures("scriptures/nt.csv", "New Testament"));
        _standardWorks.Add(LoadScriptures("scriptures/bom.csv", "Book of Mormon"));
        _standardWorks.Add(LoadScriptures("scriptures/dc.csv", "Doctrine and Covenants"));
        _standardWorks.Add(LoadScriptures("scriptures/pgp.csv", "Pearl of Great Price"));
        

    }

    private static StandardWork LoadScriptures(String fileName, String standardWorkName)
    {
        StandardWork standardWork = new StandardWork(standardWorkName);
        using (StreamReader sr = new StreamReader(fileName))
        {
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                String[] parts = line.Split(new [] { ',' }, 2);
                string reference = parts[0];
                string text = parts[1];
                int splitIndex = reference.LastIndexOf(' ');
                string book = reference.Substring(0, splitIndex).Trim();
                string[] chapterAndVerse = reference.Substring(splitIndex).Trim().Split(':');
                int chapter = int.Parse(chapterAndVerse[0]);
                int verse = int.Parse(chapterAndVerse[1]);
                Verse v = new Verse(verse, text);
                if(standardWork.GetBook(book) == null){
                    standardWork.AddBook( new Book(book));
                } 
                Book b = standardWork.GetBook(book);
                if(b.GetChapter(chapter) == null){
                        b.AddChapter(new Chapter(chapter));
                } 
                b.GetChapter(chapter).AddVerse(v);
            }
        }
        return standardWork;
    }
     public static Scripture GetScripture()
    {
        String standardWork = "";
        Menu standardWorkMenu = new Menu("Scripture Selector" , "Select a standard work", _standardWorks.Select(x => x.GetName()).ToList());
        int option = standardWorkMenu.Display(false)-1;
        standardWork = _standardWorks[option].GetName();
        Menu bookMenu = new Menu("Scripture Selector" , "Select a book", _standardWorks[option].GetBooks().Select(x => x.GetName()).ToList());
        Book book = _standardWorks[option].GetBooks()[bookMenu.Display(false)-1];
        int chapter = 0;
        while(chapter <1 || chapter > book.GetNumberOfChapters()){
            Console.Write("Select a chapter number between 1 and " + book.GetNumberOfChapters() + ": ");
            try{
                chapter = int.Parse(Console.ReadLine());
            } catch(Exception e){
                Console.WriteLine("Invalid chapter number");
            }
        }
        int startVerse = 0;
        int endVerse = 0;
        Console.WriteLine("Would you like to select a multiple verses? (y/n)");
        string response = Console.ReadLine();
        
        while(startVerse <1 || startVerse > book.GetChapter(chapter).GetNumberOfVerses()){
            Console.Write("Select a verse number between 1 and " + book.GetChapter(chapter).GetNumberOfVerses() + ": ");
            try{
                startVerse = int.Parse(Console.ReadLine());
            } catch(Exception e){
                Console.WriteLine("Invalid verse number");
            }
        }
        if(response.Equals("y") && startVerse != book.GetChapter(chapter).GetNumberOfVerses()){
            while(endVerse <= startVerse || endVerse > book.GetChapter(chapter).GetNumberOfVerses()){
                Console.Write("Select a verse number between "+(startVerse+1)+" and " + book.GetChapter(chapter).GetNumberOfVerses() + ": ");
                try{
                    endVerse = int.Parse(Console.ReadLine());
                } catch(Exception e){
                    Console.WriteLine("Invalid verse number");
                }
            }
            return GetScripture(standardWork, book.GetName(), chapter, startVerse, endVerse);
        }
        return GetScripture(standardWork, book.GetName(), chapter, startVerse);
    }

    public static Scripture GetScripture(String standardWork, String book, int chapter, int verse)
    {
        StandardWork sw = _standardWorks.Find(x => x.GetName().Equals(standardWork));
        Book b = sw.GetBook(book);
        Chapter c = b.GetChapter(chapter);
        Verse v = c.GetVerse(verse);
        return new Scripture(book, chapter, v);
    }

    public static Scripture GetScripture(String standardWork, String book, int chapter, int firstVerse, int lastVerse)
    {
        StandardWork sw = _standardWorks.Find(x => x.GetName().Equals(standardWork));
        Book b = sw.GetBook(book);
        Chapter c = b.GetChapter(chapter);
        List<Verse> verses = new List<Verse>();
        for(int i = firstVerse; i <= lastVerse; i++){
            verses.Add(c.GetVerse(i));
        }
        return new Scripture(book, chapter, verses);
    }

    public static Scripture GetRandomScripture(){
        Random rnd = new Random();
        StandardWork sw = _standardWorks[rnd.Next(0, _standardWorks.Count)];
        Book b = sw.GetBooks()[rnd.Next(0, sw.GetBooks().Count)];
        Chapter c = b.GetChapter(rnd.Next(0, b.GetNumberOfChapters()));
        Verse v = c.GetVerse(rnd.Next(0, c.GetNumberOfVerses()));
        return new Scripture(b.GetName(), c.GetChapterNumber(), v);
    }

}