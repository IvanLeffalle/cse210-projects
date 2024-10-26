public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public GoalManager()
    {
        return;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points. ");

    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The Goals Are:");
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetStringRepresentation()}");
            count++;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The Goals Are:");
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetStringRepresentation()}");
            count++;
        }
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (_goals[choice].isCompleted())
        {
            Console.WriteLine("You have already completed this goal.");
        }
        else if (_goals[choice] is SimpleGoal simpleGoal && simpleGoal.isMissed() == "missed")
        {
            Console.WriteLine("This goal is missed and cannot be completed.");
        }
        else
        {
            _goals[choice].RecordEvent();

            if (_goals[choice] is ChecklistGoal checklistGoal)
            {
                if (checklistGoal._ammountCompleted <= checklistGoal._target)
                {
                    _score += checklistGoal.GetPoints();
                }
            }
            else
            {
                _score += _goals[choice].GetPoints();
            }

            if (_goals[choice].isCompleted())
            {
                _goals[choice].SetCompleted(true);
            }
        }
    }
    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetDetailsString());
            }
            outputFile.WriteLine($"Score,{_score}");
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        _score = 0;
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string goalType = parts[0];

                    if (goalType == "Score")
                    {
                        _score = int.Parse(parts[1]);
                        continue;
                    }

                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isCompleted = bool.Parse(parts[4]);

                    if (goalType == "SimpleGoal")
                    {
                        DateTime targetDate = DateTime.Parse(parts[5]);
                        var simpleGoal = new SimpleGoal(name, description, points, targetDate);
                        simpleGoal.SetCompleted(isCompleted);
                        _goals.Add(simpleGoal);
                    }
                    else if (goalType == "EternalGoal")
                    {
                        var eternalGoal = new EternalGoal(name, description, points);
                        _goals.Add(eternalGoal);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        int amountCompleted = int.Parse(parts[5]);
                        int target = int.Parse(parts[6]);
                        int bonus = int.Parse(parts[7]);

                        var checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                        checklistGoal.SetCompleted(isCompleted);
                        checklistGoal.SetCurrentCount(amountCompleted);
                        _goals.Add(checklistGoal);
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void ListGoalType()
    {
        Console.WriteLine("The Goals Are:");
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetType()}");
            count++;
        }
    }
    public void Start()
    {
        while (true)
        {
            Console.WriteLine("");
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options: \n1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                CreateNewGoal();
            }

            else if (userChoice == "2")
            {
                ListGoalDetails();

            }
            else if (userChoice == "3")
            {
                Console.WriteLine("What is the name for the goal File? ");
                string fileName = Console.ReadLine();
                SaveGoals(fileName);
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("Enter the filename to load goals: ");
                string loadFileName = Console.ReadLine();
                LoadGoals(loadFileName);
            }
            else if (userChoice == "5")
            {
                RecordEvent();
            }
            else if (userChoice == "6")
            {
                break;
            }
        }
    }

    private void CreateNewGoal()
    {
        Console.WriteLine("The types of goals are: \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.WriteLine("What is the Name of your goal?: ");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?: ");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?: ");
        int points = int.Parse(Console.ReadLine());
        if (goalType == "1")
        {
            Console.WriteLine("Enter the target date for the goal (yyyy-MM-dd): ");
            DateTime targetDate = DateTime.Parse(Console.ReadLine());
            AddGoal(new SimpleGoal(name, description, points, targetDate));
        }
        else if (goalType == "2")
        {
            AddGoal(new EternalGoal(name, description, points));
        }
        else if (goalType == "3")
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?: ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times?: ");
            int bonus = int.Parse(Console.ReadLine());
            AddGoal(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }
}



