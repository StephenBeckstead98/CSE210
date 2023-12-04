using System; 

class FitnessApp {
    private UserDatabase userDb; 
    private FoodTracker foodTracker;
    private WorkoutPlanner workoutPlanner; 
    private Report reportGenerator; 

    public FitnessApp() {
        userDb = new UserDatabase(); 
        foodTracker = new FoodTracker(); 
        workoutPlanner = new WorkoutPlanner();
        reportGenerator = new Report();
    }

    public void Run() {
        Console.WriteLine("Welcome");
    }
}