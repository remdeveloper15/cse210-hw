using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public GoalManager()
    {
    }

    public int GetScore()
    {
        return _score;
    }

    public void Start()
    {
        int userOption = 0;
        
        while (userOption != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string userOptionString = Console.ReadLine();
            userOption = int.Parse(userOptionString);

            if (userOption == 1)
            {
                CreateGoal();
            }

            else if (userOption == 2)
            {
                
                ListGoalDetails();
            }

            else if (userOption == 3)
            {
                SaveGoals();   
            }

            else if (userOption == 4)
            {
                LoadGoals();
            }

            else if (userOption == 5)
            {
                ListGoalNames();
                RecordEvent();
            }
        }
        

    }

    public void DisplayPlayerInfo()
    {
        Goal goal = new Goal();
        string finalScoreString = goal.GetPoints();
        Console.WriteLine(finalScoreString);
        Console.WriteLine($"You have points");
    }

    public void ListGoalNames()
    {
        int count = 0;
        Console.WriteLine("");
        Console.WriteLine("The goals are: ");

        foreach(Goal g in _goals)
        {
            count += 1;
            Console.WriteLine($"  {count}. " + g.GetDetailsString2());
        }
    }

    public void ListGoalDetails()
    {
        int count = 0;

        Console.WriteLine("");
        Console.WriteLine("The goals are: ");
        
        foreach(Goal g in _goals)
        {
            count += 1;
            Console.WriteLine($"  {count}. "+ g.GetDetailsString());
        }

        Console.WriteLine("");
    }

    public void CreateGoal()
    {
        int userOption2 = 0;

        Console.WriteLine("");
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string userOptionString2 = Console.ReadLine();
        userOption2 = int.Parse(userOptionString2);

        if (userOption2 == 1)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of the goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }

        else if (userOption2 == 2)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of the goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }

        else if (userOption2 == 3)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of the goal? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string timesString = Console.ReadLine();
            int times = int.Parse(timesString);
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            string bonusString = Console.ReadLine();
            int bonus = int.Parse(bonusString);
            

            ChecklistGoal goal = new ChecklistGoal(name, description, points, times, bonus);
            _goals.Add(goal);
        }

    }

    public void RecordEvent()
    {
        int index;
        Console.Write("Which goal would you like to acomplish? ");
        string userOption3String = Console.ReadLine();
        int userOption3 = int.Parse(userOption3String);
        userOption3 = userOption3 + 1;

        foreach (Goal goal in _goals)
        {
            index = _goals.IndexOf(goal);
            goal.RecordEvent();

        }

    }

    public void SaveGoals()
    {
        Console.Write("What is the filename of the file goal? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(_score);
                outputFile.Write(goal);
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        string [] lines = System.IO.File.ReadAllLines(fileName);
        string detailString;

        foreach (string line in lines)
        {
            string [] parts = line.Split(":");
            Goal type = parts[0];
            detailString = parts[1];   
        }

    }

}