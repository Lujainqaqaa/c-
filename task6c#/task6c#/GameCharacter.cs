using System;
using System.Collections.Generic;

// Part 1: Abstract Class
abstract class GameCharacter
{
    private string _name;
    protected int Health { get; set; }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public GameCharacter(string name, int health)
    {
        _name = name;
        Health = Math.Max(0, Math.Min(100, health));
    }

    public abstract void UseSpecialAbility();

    public virtual void TakeDamage(int amount)
    {
        Health = Math.Max(0, Health - Math.Max(0, amount));
        Console.WriteLine($"{Name} takes {amount} damage.");
    }

    // Method Overloading
    public void Heal()
    {
        Health = Math.Min(100, Health + 10);
        Console.WriteLine($"{Name} heals 10 points.");
        Console.WriteLine($"{Name}'s health: {Health}");
    }

    public void Heal(int amount)
    {
        Health = Math.Min(100, Health + Math.Max(0, amount));
        Console.WriteLine($"{Name} heals {amount} points.");
        Console.WriteLine($"{Name}'s health: {Health}");
    }

    public void DisplayHealth()
    {
        Console.WriteLine($"{Name}'s health: {Health}");
    }
}
