using System;

public class FitnessRoutine
{
    private Exercise selectedExercise;

    public FitnessRoutine(Exercise exercise)
    {
        selectedExercise = exercise;
    }

    public void ExecuteRoutine()
    {
        Console.WriteLine($"\n Performing {selectedExercise.Name}:");

        selectedExercise.ExerciseWithTimer();

        CompareResultsToPreviousWorkout();
    }

    public void AddExercise(Exercise exercise)
    {
        selectedExercise = exercise;
    }

    private void CompareResultsToPreviousWorkout()
    {
        string prevResult = "Previous result";
        Console.WriteLine("\n Comparing results:");
        selectedExercise.CompareResults(prevResult);
    }
}
