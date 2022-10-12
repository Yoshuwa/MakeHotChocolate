using System;

namespace YoshuwaKalangu;

public class Cappucino
{
    public static string MakeCappucino(int intensity)
    {

        // future dev, make this dynamic
        var qty = IntensityCalculator.GetIntensityCalculator(intensity);
        Instructions.PourWater(qty);
        Instructions.addMilk(qty);
        Instructions.addSugar(qty);
        string response = $"Your Cappucino is ready! intensity was {intensity} ";
        Console.WriteLine(response);
        return response;
    }
}