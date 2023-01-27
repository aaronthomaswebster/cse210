using System;

class Loading
{
    private List<String> _lines;
    private List<String> _ufo;

    private int _direction = 1;
    private int _ufoPosition = 0;

    public Loading()
    {
        _lines = new List<String>();
        _ufo = new List<String>();
        _lines.Add("────────────────────────────────────────");
        _lines.Add("────────────────────────────────────────");
        _lines.Add("─────────█──────────────────────█───────");
        _lines.Add("─▄─█────▐▌▌───█──▄─█────▄─▄────▐▌▌───█──");
        _lines.Add("▐█▐▐▌█▌▌█▌█▌▄█▐▌▐█▐▐▌█▌▐█▐▐▌█▌▌█▌█▌▄█▐▌▌");
        _lines.Add("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
        _lines.Add("█ █░░ █▀▀█ ▄▀▀▀▄ █▀▀▄░ ▀█▀░ █▀▀▄ █▀▀▀▀ █");
        _lines.Add("█ █░░ █░░█ █▀▀▀█ █░░█▀░ █░░ █░░█ █░▀▀▄ █");
        _lines.Add("█ ▀▀▀ ▀▀▀▀ ▀░░░▀ ▀▀▀ ░ ▀▀▀░ ▀░░▀ ▀▀▀▀▀ █");
        _lines.Add("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
        _ufo.Add("▄▀█▀█▀▄");
        _ufo.Add("▀▀▀▀▀▀▀▀▀");
        _ufo.Add("░░░░░");
        _ufo.Add("░░░░░");
        _ufo.Add("░░░░░");
    }
    public void showNextFrame()
    {

            List<String> printString = new List<String>();
            printString.Add(_lines[0].SubString(0,_ufoPosition+((9-_ufo[0].Length)/2))+_ufo[0]+_lines[0].SubString(_ufoPosition+((9-_ufo[0].Length)/2)+_ufo[0].Length));
            printString.Add(_lines[1].SubString(0,_ufoPosition+((9-_ufo[1].Length)/2))+_ufo[1]+_lines[1].SubString(_ufoPosition+((9-_ufo[1].Length)/2)+_ufo[1].Length));
            printString.Add(_lines[2].SubString(0,_ufoPosition+((9-_ufo[2].Length)/2))+_ufo[2]+_lines[2].SubString(_ufoPosition+((9-_ufo[2].Length)/2)+_ufo[2].Length));
            printString.Add(_lines[3].SubString(0,_ufoPosition+((9-_ufo[3].Length)/2))+_ufo[3]+_lines[3].SubString(_ufoPosition+((9-_ufo[3].Length)/2)+_ufo[3].Length));
            printString.Add(_lines[4].SubString(0,_ufoPosition+((9-_ufo[4].Length)/2))+_ufo[4]+_lines[4].SubString(_ufoPosition+((9-_ufo[4].Length)/2)+_ufo[4].Length));
            printString.Add(_lines[5]);
            printString.Add(_lines[6]);
            printString.Add(_lines[7]);
            printString.Add(_lines[8]);
            printString.Add(_lines[9]);


            Console.Clear();
            foreach (String line in printString)
            {
                Console.WriteLine(line);
            }
            Thread.Sleep(40);
            _ufoPosition+=_direction;
            if (_ufoPosition > 30)
            {
                _direction = -1;
                _ufoPosition = 30;
            }
            if (_ufoPosition < 1)
            {
                _direction = 1;
                _ufoPosition = 1;
            }
    }
}