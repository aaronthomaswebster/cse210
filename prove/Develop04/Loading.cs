using System;

class Loading
{
    private List<string> _lines;
    private List<string> _ufo;

    private string _loadingText;

    private int _direction = 1;
    private int _ufoPosition = 0;

    public Loading(string loadingText)
    {

        _loadingText = loadingText;
        if(_loadingText.Length > 20){
            _loadingText = _loadingText.Substring(0, 20);
        }
        if(_loadingText == ""){
            _loadingText = "          ";
        }
        _lines = new List<string>();
        _ufo = new List<string>();

        _ufo.Add("▄▀█▀█▀▄");
        _ufo.Add("▀▀▀▀▀▀▀▀▀");
        _ufo.Add("░░░░░");
        _ufo.Add("░░░░░");
        _ufo.Add("░░░░░");

        _lines.Add("─");
        _lines.Add("─");
        _lines.Add("─");
        _lines.Add("─");
        _lines.Add("▐");
        _lines.Add("█");
        _lines.Add("█");
        _lines.Add("█");
        _lines.Add("█");
        _lines.Add("█");

        List<string> wordArt = getWordArt(_loadingText);
        for (int i = 0; i < wordArt.Count; i++)
        {
            _lines[i + 6] += wordArt[i];
        }

        List<string> cityScape = getCity(wordArt[0].Length);
        for (int i = 0; i < cityScape.Count; i++)
        {

            _lines[i] += cityScape[i];
        }
        for(int i = 0; i < wordArt[0].Length; i++){
            _lines[5] += "▀";
            _lines[9] += "▄";
        }

       
        _lines[0] += "─";
        _lines[1] += "─";
        _lines[2] += "─";
        _lines[3] += "─";
        _lines[4] += "▌";
        _lines[5] += "█";
        _lines[6] += "█";
        _lines[7] += "█";
        _lines[8] += "█";
        _lines[9] += "█";


    }
    public void showNextFrame(Boolean clearScreen)
    {

        List<string> printstring = new List<string>();
        printstring.Add(_lines[0].Substring(0, _ufoPosition + ((9 - _ufo[0].Length) / 2)) + _ufo[0] + _lines[0].Substring(_ufoPosition + ((9 - _ufo[0].Length) / 2) + _ufo[0].Length));
        printstring.Add(_lines[1].Substring(0, _ufoPosition + ((9 - _ufo[1].Length) / 2)) + _ufo[1] + _lines[1].Substring(_ufoPosition + ((9 - _ufo[1].Length) / 2) + _ufo[1].Length));
        printstring.Add(_lines[2].Substring(0, _ufoPosition + ((9 - _ufo[2].Length) / 2)) + _ufo[2] + _lines[2].Substring(_ufoPosition + ((9 - _ufo[2].Length) / 2) + _ufo[2].Length));
        printstring.Add(_lines[3].Substring(0, _ufoPosition + ((9 - _ufo[3].Length) / 2)) + _ufo[3] + _lines[3].Substring(_ufoPosition + ((9 - _ufo[3].Length) / 2) + _ufo[3].Length));
        printstring.Add(_lines[4].Substring(0, _ufoPosition + ((9 - _ufo[4].Length) / 2)) + _ufo[4] + _lines[4].Substring(_ufoPosition + ((9 - _ufo[4].Length) / 2) + _ufo[4].Length));
        printstring.Add(_lines[5]);
        printstring.Add(_lines[6]);
        printstring.Add(_lines[7]);
        printstring.Add(_lines[8]);
        printstring.Add(_lines[9]);

        if (clearScreen)
        {
            Console.Clear();
        }
        foreach (string line in printstring)
        {
            Console.WriteLine(line);
        }
        
        Console.WriteLine("");
        Console.WriteLine("");
        _ufoPosition += _direction;
        if (_ufoPosition >  _lines[0].Length - 10)
        {
            _direction = -1;
            _ufoPosition = _lines[0].Length - 10;
        }
        if (_ufoPosition < 1)
        {
            _direction = 1;
            _ufoPosition = 1;
        }
    }

    private static List<string> getCity(int size)
    {
        List<string> city = new List<string>();

        Random rnd = new Random();
        city.Add("");
        city.Add("");
        city.Add("");
        city.Add("");
        city.Add("");

        while (size > 0)
        {
            int building = rnd.Next(1, 5);
            if (building > size)
            {
                building = size;
            }

            switch (building)
            {
                case 1:
                    switch(rnd.Next(1, 4)){
                        case 1:
                            city[0] += "─";
                            city[1] += "─";
                            city[2] += "─";
                            city[3] += "─";
                            city[4] += "▐";
                            break;
                        default:
                            city[0] += "─";
                            city[1] += "─";
                            city[2] += "─";
                            city[3] += "─";
                            city[4] += "█";
                            break;
                    }
                    break;
                case 2:
                    city[0] += "──";
                    city[1] += "──";
                    city[2] += "──";
                    city[3] += "─▄";
                    city[4] += "▐█";
                    break;
                case 3:
                    city[0] += "───";
                    city[1] += "───";
                    city[2] += "───";
                    city[3] += "─█─";
                    city[4] += "▐▐▌";
                    break;
                case 4:
                    city[0] += "────";
                    city[1] += "────";
                    city[2] += "─█──";
                    city[3] += "▐▌▌─";
                    city[4] += "█▌█▌";
                    break;
            }
            size -= building;
        }
        return city;
    }

    private static List<string> getWordArt(String word)
    {
        List<string> artString = new List<string>();
        artString.Add("");
        artString.Add("");
        artString.Add("");

        artString[0] += "░";
        artString[1] += "░";
        artString[2] += "░";

        foreach (char c in word)
        {
            switch (c)
            {
                case 'A':
                case 'a':
                    artString[0] += "▄▀▀▀▄";
                    artString[1] += "█▀▀▀█";
                    artString[2] += "█░░░█";
                    break;
                case 'B':
                case 'b':
                    artString[0] += "█▀▀▀▄";
                    artString[1] += "█▀▀▀█";
                    artString[2] += "█▄▄▄▀";
                    break;
                case 'C':
                case 'c':
                    artString[0] += "▄▀▀▀▄";
                    artString[1] += "█░░░ ";
                    artString[2] += "▀▄▄▄▀";
                    break;
                case 'D':
                case 'd':
                    artString[0] += "█▀▀▀▄";
                    artString[1] += "█░░░█";
                    artString[2] += "█▄▄▄▀";
                    break;
                case 'E':
                case 'e':
                    artString[0] += "█▀▀▀▀";
                    artString[1] += "█▀▀▀▀";
                    artString[2] += "█▄▄▄▄";
                    break;
                case 'F':
                case 'f':
                    artString[0] += "█▀▀▀▀";
                    artString[1] += "█▀▀▀▀";
                    artString[2] += "█░░░░";
                    break;
                case 'G':
                case 'g':
                    artString[0] += "█▀▀▀▀";
                    artString[1] += "█░▀▀▄";
                    artString[2] += "█▄▄▄█";
                    break;
                case 'H':
                case 'h':
                    artString[0] += "█░░░█";
                    artString[1] += "█▀▀▀█";
                    artString[2] += "█░░░█";
                    break;
                case 'I':
                case 'i':
                    artString[0] += "▀▀█▀▀";
                    artString[1] += "  █░░";
                    artString[2] += "▄▄█▄▄";
                    break;
                case 'J':
                case 'j':
                    artString[0] += "▀▀█▀▀";
                    artString[1] += "░░█░░";
                    artString[2] += "▄▄█░░";
                    break;
                case 'K':
                case 'k':
                    artString[0] += "█░░▄▀";
                    artString[1] += "█▀▀▄░";
                    artString[2] += "█░░▀▄";
                    break;
                case 'L':
                case 'l':
                    artString[0] += "█░░░";
                    artString[1] += "█░░░";
                    artString[2] += "█▄▄▄";
                    break;
                case 'M':
                case 'm':
                    artString[0] += "▄▀▀█▀▀▄";
                    artString[1] += "█░░█░░█";
                    artString[2] += "█░░█░░█";
                    break;
                case 'N':
                case 'n':
                    artString[0] += "█▀▀▀▄";
                    artString[1] += "█░░░█";
                    artString[2] += "█░░░█";
                    break;
                case 'O':
                case 'o':
                    artString[0] += "▄▀▀▀▄";
                    artString[1] += "█░░░█";
                    artString[2] += "▀▄▄▄▀";
                    break;
                case 'P':
                case 'p':
                    artString[0] += "█▀▀▀▄";
                    artString[1] += "█▄▄▄█";
                    artString[2] += "█░░░░";
                    break;
                case 'Q':
                case 'q':
                    artString[0] += "▄▀▀▀▄░";
                    artString[1] += "█░░░█░";
                    artString[2] += "▀▄▄▄▀▄";
                    break;
                case 'R':
                case 'r':
                    artString[0] += "█▀▀▀▄░";
                    artString[1] += "█▄▄▄█░";
                    artString[2] += "█░░░▀▄";
                    break;
                case 'S':
                case 's':
                    artString[0] += "▄▀▀▀▄";
                    artString[1] += "▀▄▄▄ ";
                    artString[2] += "▄▄▄▄▀";
                    break;
                case 'T':
                case 't':
                    artString[0] += "▀▀█▀▀";
                    artString[1] += "░░█░░";
                    artString[2] += "░░█░░";
                    break;
                case 'U':
                case 'u':
                    artString[0] += "█░░░█";
                    artString[1] += "█░░░█";
                    artString[2] += "▀▄▄▄▀";
                    break;
                case 'V':
                case 'v':
                    artString[0] += "█░░░█";
                    artString[1] += "█░░░█";
                    artString[2] += " ▀▄▀ ";
                    break;
                case 'W':
                case 'w':
                    artString[0] += "█░░█░░█";
                    artString[1] += "█░░█░░█";
                    artString[2] += "▀▄▄█▄▄▀";
                    break;
                case 'X':
                case 'x':
                    artString[0] += "█░░░█";
                    artString[1] += " ▀▄▀ ";
                    artString[2] += "█░░░█";
                    break;
                case 'Y':
                case 'y':
                    artString[0] += "█░░░█";
                    artString[1] += " ▀▄▀ ";
                    artString[2] += "░░█░░";
                    break;
                case 'Z':
                case 'z':
                    artString[0] += "▀▀▀█";
                    artString[1] += "░▄▀░";
                    artString[2] += "█▄▄▄";
                    break;
                default:
                    artString[0] += "░░░";
                    artString[1] += "░░░";
                    artString[2] += "░░░";
                    break;
            }

            artString[0] += "░";
            artString[1] += "░";
            artString[2] += "░";
        }
        return artString;
    }
}