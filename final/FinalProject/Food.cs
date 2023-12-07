public class FoodItem
{
    public string Name { get; set; }
    public int Calories { get; set; }

    public FoodItem(string name, int calories)
    {
        Name = name;
        Calories = calories;
    }
}
