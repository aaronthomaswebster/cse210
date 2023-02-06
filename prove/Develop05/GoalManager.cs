using System;

public class GoalManager
{

    private List<Goal> goals = new List<Goal>();

    public GoalManager()
    {

    }

    public void run(){
        List<String> mainMenuOptions = new List<String>();
        mainMenuOptions.Add("Create New Goal");
        mainMenuOptions.Add("List Goals");
        mainMenuOptions.Add("Save Goals");
        mainMenuOptions.Add("Load Goals");
        mainMenuOptions.Add("Record Event");
        Menu mainMenu = new Menu("Main Menu", "Select a choice from the menu",mainMenuOptions);
        int menuOption = mainMenu.Display();
        switch (menuOption)
        {
            case 1:
                createNewGoal();
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            default:
             break;
        }

    }

    private void createNewGoal(){
        List<String> newGoalOptions = new List<String>();
        newGoalOptions.Add("Simple Goal");
        newGoalOptions.Add("Eternal Goal");
        newGoalOptions.Add("Checklist Goals");
        newGoalOptions.Add("Go Back");
        Menu newGoalMenu = new Menu("New Goal Menu", "The Types of Goals are:",newGoalOptions);
        int menuOption =  newGoalMenu.Display(false);
        if(menuOption == 4)
            return;
        Console.Clear();
        String goalName = askAQuestion("What is the name of the goal?");
        String goalDescription = askAQuestion("What is the description of the goal?");
        int goalIncramentScore = Int32.Parse(askAQuestion("What is the score I should recive for working on this goal?"));

        switch (menuOption)
        {
            case 1:
                goals.Add( new SimpleGoal());
                break;
            case 2:
                goals.Add( new EternalGoal());
                break;
            case 3:
                goals.Add( new ListGoal());
                break;
        }

    }

    private String askAQuestion(String question){
        Console.WriteLine(question);
        Console.Write("> ");
        return Console.ReadLine();
    }
}