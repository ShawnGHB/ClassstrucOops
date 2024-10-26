using System;

public class Adventurer
{

    public string name;
    public int xp = 0;


    public Adventurer(string name)
    {
        this.name = name;
        //Reset();
    }
    public Adventurer()
    {
        name = "Not assigned";
    }
    public virtual void PrintStatsInfo()
    {
        Console.WriteLine("Hero: " + this.name + " - " + this.xp + " EXP");
    }
    private void Reset()
    {
        this.name = "Not assigned";
        this.xp = 0;
    }
}

