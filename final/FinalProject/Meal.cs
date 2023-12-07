using System;
using System.Collections.Generic;
using System.Linq;

public class Meal
{
    public string Name { get; set; }
    public List<FoodItem> Foods { get; set; }

    public Meal(string name)
    {
        Name = name;
        Foods = new List<FoodItem>();
    }

    public void AddFoodItem(FoodItem foodItem)
    {
        Foods.Add(foodItem);
    }

    public int CalculateTotalCalories()
    {
        return Foods.Sum(food => food.Calories);
    }
}
