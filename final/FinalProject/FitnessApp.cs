using System;

public class FitnessApp
{
    private FitnessRoutine fitnessRoutine;
    private DietTracker dietTracker;

    public FitnessApp()
    {
        fitnessRoutine = new FitnessRoutine(new CardioExercise("Default Cardio Exercise", 5));
        dietTracker = new DietTracker();
    }

    public void Run()
    {
        Console.WriteLine("Welcome to my Fitness App!");

        while (true)
        {
            Console.WriteLine("\n Main Menu:");
            Console.WriteLine("1. Start Workout");
            Console.WriteLine("2. Track Food Intake");
            Console.WriteLine("3. Exit");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        PerformWorkout();
                        break;
                    case 2:
                        TrackFoodIntake();
                        break;
                    case 3:
                        Console.WriteLine("Thank you for using Fitness App!");
                        return;
                    default:
                        Console.WriteLine("Please enter a number between 1 and 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
            }
        }
    }

    private void PerformWorkout()
    {
        Exercise selectedExercise = null;

        Console.WriteLine("\n Select exercises for your workout:");
        Console.WriteLine("1. Running");
        Console.WriteLine("2. Push-ups");
        Console.WriteLine("3. Exit");

        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 1:
                    selectedExercise = CreateCardioExercise();
                    break;
                case 2:
                    selectedExercise = CreateStrengthExercise();
                    break;
                case 3:
                    return; 
                default:
                    Console.WriteLine("Please enter a number between 1 and 3.");
                    return;
            }
        }
        else
        {
            Console.WriteLine("Please enter a number.");
            return;
        }

        fitnessRoutine.AddExercise(selectedExercise);

        Console.WriteLine("\n Your workout routine:");
        fitnessRoutine.ExecuteRoutine();
    }

    private CardioExercise CreateCardioExercise()
    {
        Console.Write("Enter the exercie you are going to do: ");
        string name = Console.ReadLine();

        Console.Write("Enter how many times you are going to do it: ");
        int intensity;
        while (!int.TryParse(Console.ReadLine(), out intensity))
        {
            Console.WriteLine("Please enter a valid number for intensity.");
            Console.Write("Enter a number for how intense the workout will be: ");
        }

        return new CardioExercise(name, intensity);
    }

    private StrengthExercise CreateStrengthExercise()
    {
        Console.Write("Enter the name of the strength exercise: ");
        string name = Console.ReadLine();

        Console.Write("Enter the number of reps for the strength exercise you chose: ");
        int repetitions;
        while (!int.TryParse(Console.ReadLine(), out repetitions))
        {
            Console.WriteLine("Please enter a number for reps.");
            Console.Write("Enter the number of reps for the strength exercise: ");
        }

        return new StrengthExercise(name, repetitions);
    }

    private void TrackFoodIntake()
    {
        dietTracker.TrackFoodIntake();
    }
}
