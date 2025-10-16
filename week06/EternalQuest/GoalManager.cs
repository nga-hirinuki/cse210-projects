using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Reflection.Metadata;
public class GoalManager
{
    protected List<Goal> _goal = new List<Goal>();
   protected int _score = 0;
    
    // Getter and Setter Functions
    public List<Goal> GetGoal() { return _goal; }
    public void SetGoal(List<Goal> goals) { _goal = goals; }
    public int GetScore() { return _score; }
    public void SetScore(int score) { _score = score; }

//constructor - initializing the attributes
     public GoalManager()
    {
    
    }
//methods
    public void Start()
    {
        int input = 0;
        do
        {
        //Display the main menu & display player info
        DisplayPlayerInfo();

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        input = int.Parse(Console.ReadLine());

            if (input == 1) { CreateGoals(); }
            else if (input == 2) { ListGoalDetails(); }
            else if (input == 3) { SaveGoals(); }
            else if (input == 4) { LoadGoals(); }
            else if (input == 5) { RecordEvent(); }
            else if (input == 6) { Console.WriteLine("Goodbye!"); }
            else { Console.WriteLine("Invalid input."); }

        } while (input != 6);

    }
    public void DisplayPlayerInfo()
    {//Display the points
       Console.WriteLine($"\nYou have {_score} points.\n");
    }
    public void ListGoalNames()
    {// Loop through the list of goals and display the names 
    // You may need another function in the goal class
        if (_goal == null || _goal.Count == 0)
        {
            Console.WriteLine("No goals to display.");
            return;
        }

        for (int i = 0; i < _goal.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goal[i].GetName()}");
        }
    }
    public void ListGoalDetails()
    {// Loop through the list of goals and display the full details
        if (_goal == null || _goal.Count == 0)
        {
            Console.WriteLine("No goals to display.");
            return;
        }

        for (int i = 0; i < _goal.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goal[i].GetName()} - {_goal[i].GetDescription()}");
        }
    }

    public void CreateGoals()
    {// display a sub menu to select a goal type
    // Ask for the name, desciption, and points
    //Ask for more if they pick checklist goal
    //Create the object and add to the goal list
        Console.WriteLine("The types of Goals are");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goals");
        Console.WriteLine("3. Checklist Goals");
        Console.Write("Which type of goal would you like to create ");
        string input = Console.ReadLine();
    

        Console.Write("What is the name of your goal ");
        string shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid number of points.");
            return;
        }
        
        int target = 0;
        int bonus = 0;

        if (input == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            if (!int.TryParse(Console.ReadLine(), out target))
            {
                Console.WriteLine("Invalid number.");
                return;
            }
            Console.Write("What is the bonus for accomplishing it that many times? ");
            if (!int.TryParse(Console.ReadLine(), out bonus))
            {
                Console.WriteLine("Invalid number.");
                return;
            }
        }
        
        if (input == "1")
        {
        //Create the object and add to the goal list
            SimpleGoal sg = new SimpleGoal(shortName, description, points);
            _goal.Add(sg);
        // show stored list
            Console.WriteLine($"{shortName} : {description} | {points} points");  
        }
    
        else if (input == "2")
        {
            EternalGoal eg = new EternalGoal(shortName, description, points);
            _goal.Add(eg);

            Console.WriteLine($"{shortName} : {description} | {points} points");
        }  
        else if (input == "3")
        {
            ChecklistGoal cg = new ChecklistGoal( shortName, description, points, target, bonus);
            _goal.Add(cg);

            Console.WriteLine($"{shortName} : {description} | {points} points | Target: {target} | Bonus: {bonus}");

        }  
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }

                    

    public void RecordEvent()
    {//Display a list of all the goal names
    //Ask user to select a goal
    //Call RecordEvent on the correct goal
    // Update the score based on the points
    //Display current points
     
        if (_goal == null || _goal.Count == 0)
        {
            Console.WriteLine("There are no goals to record events for.");
            return;
        }
        // Display a list of all goal names
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goal.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goal[i].GetName()} | {_goal[i].GetDetailsString()} |{_goal[i].GetPoints()}");
        }

        // Ask the user which goal they accomplished
        Console.Write("Which goal did you accomplish? ");
        if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > _goal.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        // Get the selected goal
        Goal selectedGoal = _goal[choice - 1];

        // Call RecordEvent on the selected goal
        int points = selectedGoal.RecordEvent();

        // Update score
        _score += points;

        // Feedback
        Console.WriteLine($"Congratulations! You earned {points} points!");
        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {// Ask user for a file name
    //Loop through the goals and convert eachgoal to a string and then save the string GetStringRepresentation();
       
    Console.Write("Enter the filename to save goals (e.g., myFile.txt): ");
    string filePath = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(filePath))
    {
        foreach (Goal goal in _goal)
        {
            // We'll save a different format depending on goal type
            if (goal is SimpleGoal sg)
            {
                // Format: SimpleGoal,Name,Description,Points,Completed
                outputFile.WriteLine($"SimpleGoal,{sg.GetName()},{sg.GetDescription()},{sg.GetPoints()},{sg.GetIsComplete()}");
            }
            else if (goal is EternalGoal eg)
            {
                // Format: EternalGoal,Name,Description,Points
                outputFile.WriteLine($"EternalGoal,{eg.GetName()},{eg.GetDescription()},{eg.GetPoints()}");
            }
            else if (goal is ChecklistGoal cg)
            {
                // Format: ChecklistGoal,Name,Description,Points,Target,Bonus,AmountCompleted
                outputFile.WriteLine($"ChecklistGoal,saved to {cg.GetDetailsString}{cg.GetName()},{cg.GetDescription()},{cg.GetPoints()},{cg.GetTarget()},{cg.GetBonus()},{cg.GetAmountCompleted()}");
            }
        
        }

            Console.WriteLine("✅ Goals saved successfully!");
         Console.WriteLine($"✅ Goalssaved to {Path.GetFullPath(filePath)}");
    }

    }

    public void LoadGoals()
    {//Ask user for a file name
    //Read each line of the file and split it up
    //User the parts to re-create the Goal object
       
        Console.Write("Enter the filename to load goals from (e.g., myFile.txt): ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goal.Clear();  // Clear existing goals before loading new ones

        foreach (string line in lines)
        {
            // Example format: SimpleGoal,Run 5k,Run 5 kilometers,50,true
            string[] parts = line.Split(',');

            if (parts.Length < 4)
            {
                Console.WriteLine($"Skipping invalid line: {line}");
                continue;
            }

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);


            if (goalType == "SimpleGoal")
            {
                bool completed = bool.Parse(parts[4]);
                SimpleGoal sg = new SimpleGoal(name, description, points);
                sg.SetIsComplete(completed);
                _goal.Add(sg);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal eg = new EternalGoal(name, description, points);
                _goal.Add(eg);
            }
            else if (goalType == "ChecklistGoal")
            {
                // Expected format: ChecklistGoal,name,desc,points,target,bonus,amountCompleted
                if (parts.Length >= 7)
                {
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int amountCompleted = int.Parse(parts[6]);

                    ChecklistGoal cg = new ChecklistGoal( name, description, points, target, bonus);
                    cg.SetAmountCompleted(amountCompleted); // Assuming setter exists
                    _goal.Add(cg);
                }
                else
                {
                    Console.WriteLine($"Invalid ChecklistGoal line: {line}");
                }
            }
            else
            {
                Console.WriteLine($"Unknown goal type: {goalType}");
            }
        }
        Console.WriteLine("✅ Goals loaded successfully!");
    }
    
}