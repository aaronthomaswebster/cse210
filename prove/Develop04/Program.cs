using System;

class Program
{
    static void Main(string[] args)
    {

        int choice = -1;
        while (choice != 0)
        {

            Menu homeMenu = new Menu(
                "Mindfullness Exercises",
                "Welcome, please select an action?",
                new List<String> { "Start breathing activity", "Start reflecting activity", "Start listing activity" }
            );
            choice = homeMenu.Display();
            Console.Clear();
            
            BreathingActivity breathingActivity = new BreathingActivity();
            ReflectingActivity reflectingActivity = new ReflectingActivity();
            ListingActivity listingActivity = new ListingActivity();

            switch (choice)
            {
                case 1:
                    breathingActivity.Begin();
                    break;
                case 2:
                    reflectingActivity.Begin();
                    break;
                case 3:
                    listingActivity.Begin();
                    break;
                default:
                    return;
            }
        }
    }
}


/*

using System;

class Program 
{
    static void Main(string[] args)
    {

        
        Menu homeMenu = new Menu(
            "Developing Mindfulness", 
            "Welcome, which activity would you use to practice Mindfulness?",
            new List<String>{"Start breathing activity", "Start reflecting activity", "Start Listing activity"}
        );

        int choice = homeMenu.Display();


        Console.WriteLine("Hello Develop04 World!");
        Loading loader = new Loading();
        while(1==1){
            loader.showNextFrame();
            Thread.Sleep(25);
        }
    }
}
    
    */