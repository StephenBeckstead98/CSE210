using System;
using System.IO;

public class DietTracker
{
    private const string MealLogFileName = "meal_log.txt";

    public void TrackFoodIntake()
    {
        Console.WriteLine("\n Track Food Intake:");
        Console.WriteLine("Enter 'breakfast', 'lunch', or 'dinner' to log your meal.");
        string mealType = Console.ReadLine().ToLower();

        switch (mealType)
        {
            case "breakfast":
                LogMeal("breakfast");
                break;
            case "lunch":
                LogMeal("lunch");
                break;
            case "dinner":
                LogMeal("dinner");
                break;
            default:
                Console.WriteLine("Please enter breakfast, lunch, or dinner.");
                break;
        }
    }

    private void LogMeal(string mealType)
    {
        Console.Write($"Enter details for your {mealType}: ");
        string mealDetails = Console.ReadLine();

        File.AppendAllText(MealLogFileName, $"{mealType}: {mealDetails}{Environment.NewLine}");

        Console.WriteLine("Meal logged successfully!");
    }
}
