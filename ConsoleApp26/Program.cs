using System;

public class Fruit
{
    // Private member variables
    private string name;
    private string color;
    private double weight; // in grams
    private bool isRipe;

    // Constructor to initialize the fruit's properties
    public Fruit(string name, string color, double weight)
    {
        this.name = name;
        this.color = color;
        this.weight = weight;
        this.isRipe = false;  // Assume the fruit is unripe when first created
    }

    // Method to simulate ripening the fruit
    public void Ripen()
    {
        if (!isRipe)
        {
            isRipe = true;
            Console.WriteLine($"{name} has ripened!");
        }
        else
        {
            Console.WriteLine($"{name} is already ripe.");
        }
    }

    // Method to simulate eating the fruit
    public void Eat()
    {
        if (isRipe)
        {
            Console.WriteLine($"You ate the {name}. It was delicious!");
        }
        else
        {
            Console.WriteLine($"The {name} is not ripe yet. You can't eat it.");
        }
    }

    // Method to display the fruit's details
    public void DisplayDetails()
    {
        Console.WriteLine($"Fruit: {name}");
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Weight: {weight} grams");
        Console.WriteLine($"Ripe: {isRipe}");
    }

    // Method to check if the fruit is ripe
    public bool IsRipe()
    {
        return isRipe;
    }
}

public class Program
{
    public static void Main()
    {
        // Create an instance of a fruit (e.g., an orange)
        Fruit orange = new Fruit("Orange", "Orange", 150);

        // Display details of the fruit
        orange.DisplayDetails();

        // Try to eat the fruit before ripening
        orange.Eat();

        // Ripen the fruit
        orange.Ripen();

        // Try to eat the fruit again after ripening
        orange.Eat();

        // Display updated details
        orange.DisplayDetails();
    }
}
