public class StrengthExercise : Exercise
{
    public int Repetitions { get; set; }
    private const int DefaultDuration = 30; 

    public StrengthExercise(string name, int repetitions)
        : base(name)
    {
        Repetitions = repetitions;
    }

    public override void ExerciseWithTimer()
    {
        Console.WriteLine($"Get ready for {Name}!");
        Console.WriteLine($"Perform {Repetitions} repetitions of {Name}.");

        Console.WriteLine("Timer started:");
        for (int i = DefaultDuration; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            System.Threading.Thread.Sleep(1000);
        }

        Console.Write("Enter your results: ");
        Result = Console.ReadLine();
    }

    public override void EndExercise()
    {
        Console.WriteLine("Workout ended. Enter result: ");
        Result = Console.ReadLine();
    }
}
