public class CardioExercise : Exercise
{
    public int Intensity { get; set; }
    private const int DefaultDuration = 30; // seconds

    public CardioExercise(string name, int intensity)
        : base(name)
    {
        Intensity = intensity;
    }

    public override void ExerciseWithTimer()
    {
        Console.WriteLine($"Get ready for {Name}!");
        Console.WriteLine($"Start running at an intensity of {Intensity} for {DefaultDuration} seconds.");

        Console.WriteLine("Timer started:");
        for (int i = DefaultDuration; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            System.Threading.Thread.Sleep(1000);
        }

        Console.Write("Enter results on a scale of 1-5: ");
        Result = Console.ReadLine();
    }

    public override void EndExercise()
    {
        Console.WriteLine("Workout ended. Enter workout results: ");
        Result = Console.ReadLine();
    }
}
