using System;

class StandardWork
{
    private String _name;
    private List<Book> _books;

    public StandardWork(string name){
        _name = name;
        _books = new List<Book>();
    }

    public void AddBook(Book book){
        _books.Add(book);
    }

    public  List<Book> GetBooks(){
        return _books;
    }

    public Book GetBook(String name){
        Book b =  _books.Find(x => x.GetName().Equals(name));
        return b;
    }

    public List<String> GetBookNames(){
        List<String> bookNames = new List<String>();
        foreach(Book b in _books){
            bookNames.Add(b.GetName());
        }
        return bookNames;
    }
    
    public String GetName(){
        return _name;
    }
}