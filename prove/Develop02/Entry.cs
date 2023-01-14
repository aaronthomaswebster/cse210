using System;

class Entry
{
    private String _dateString;
    private String _prompt;
    private String _response;

    public Entry(String date, String prompt, String response){
        _dateString = date;
        _prompt = prompt;
        _response = response;
    }

    public Entry(String entryString){
        String[] entryParts = entryString.Split("~||~");
        _dateString = entryParts[0];
        _prompt = entryParts[1];
        _response = entryParts[2];
    }

    public String Save(){
        return $"{_dateString}~||~{_prompt}~||~{_response}";
    }

    public void Display(){
        Console.WriteLine($"{_dateString}\n{_prompt}\n{_response}\n\n");
    }
}