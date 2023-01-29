using System;

class BreathingActivity : Activity
{

    private int _inhale;

    private int _exhale;

    private Loading _InhaleLoader;

    private Loading _ExhaleLoader;
    public BreathingActivity() : base("Breathing Activity", "This activity will help you to focus on your breathing")
    {
        _InhaleLoader = new Loading("Inhale");
        _ExhaleLoader = new Loading("Exhale");
    }

    public void Begin(){
    
        Welcome();

        Console.Write("How long, in seconds, would you like to inhale for? ");
        _inhale = Convert.ToInt32(Console.ReadLine());

        Console.Write("How long, in seconds, would you like to exhale for? ");
        _exhale = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Press any key to begin");
        Console.ReadKey();

        BreathInBreathOut();

        EndActivity();

        
    }


    private void BreathInBreathOut(){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        string stage = "Inhale";

        DateTime nextStageChange = ( DateTime.Now).AddSeconds(_inhale);
        
        while( DateTime.Now < endTime){      
            if(stage == "Inhale"){
                _InhaleLoader.showNextFrame(true);
            }else{
                _ExhaleLoader.showNextFrame(true);
            }
            if( DateTime.Now > nextStageChange){
                if(stage == "Inhale"){
                    stage = "Exhale";
                    nextStageChange =  ( DateTime.Now).AddSeconds(_exhale );
                }else{
                    stage = "Inhale";
                    nextStageChange =  ( DateTime.Now).AddSeconds(_inhale);
                }
            }            
            Thread.Sleep(24);
        }
    }
}