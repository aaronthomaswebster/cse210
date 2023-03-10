using System;

public class Activity{

    protected String _title;
    protected String _description;
    
    protected int _duration;

    public Activity(String title, String description){
        _title = title;
        _description = description;
    }

    protected void Welcome(){
        Console.WriteLine(_title);
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like to spend this session? ");
        _duration = Convert.ToInt32(Console.ReadLine());
    }

    protected void EndActivity(){      

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Well done!");
        ShowSpinner(3);

        Console.WriteLine();

        Console.Write($"You have completed another {_duration} seconds of mindfulness practice in the {_title}");

        ShowSpinner(5);
    }

    protected void SetDuration(int duration){
        _duration = duration;
    }

    protected void ShowSpinner( int duration){
        int startTime = Environment.TickCount;
        int endTime = startTime + (duration * 1000);
        int loop = 0;
        List<char> spinner = new List<char>{'|', '/', '-', '\\'};
        while(Environment.TickCount < endTime){            
            Console.Write(spinner[loop%spinner.Count]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            loop++;
        }
    }
}