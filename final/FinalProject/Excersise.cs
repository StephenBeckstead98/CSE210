using System;

public abstract class Exercise
{
    public string Name { get; set; }
    public string Result { get; set; }

    public Exercise(string name)
    {
        Name = name;
    }

    public abstract void ExerciseWithTimer();
    public abstract void EndExercise();

    public void CompareResults(string prevResult)
    {
        if (Result == prevResult)
        {
            Console.WriteLine($"Great! Your result is the same as the previous: {Result}");
        }
        else
        {
            Console.WriteLine($"Congratulations! Improved. Previous result: {prevResult}, Current result: {Result}");
        }
    }
}
