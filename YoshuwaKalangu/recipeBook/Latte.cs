using System;

namespace YoshuwaKalangu;

public class Latte
{
    private HotBeverageMaker _hotBeverageMaker;

    public Latte(HotBeverageMaker hotBeverageMaker)
    {
        _hotBeverageMaker = hotBeverageMaker;
    }

    public static void MakeLatte(int intensity)
    {
        Instructions.PourWater(4);
        Instructions.addBeans(4);
        Instructions.addMilk(2);
        Instructions.addSugar(4);
        Console.WriteLine($"Your Latte is ready with intensity {intensity}");
    }

    // HotChoc
    public static void HotChoc(int intensity)
    {
        Instructions.PourWater(4);
        Instructions.addBeans(4);
        Instructions.addMilk(2);
        Instructions.addSugar(4);
        Console.WriteLine($"Your Hot Choc is ready with intensity {intensity}");
    }

}