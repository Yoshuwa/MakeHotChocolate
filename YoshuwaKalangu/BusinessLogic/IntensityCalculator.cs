namespace YoshuwaKalangu;

public class IntensityCalculator
{
    public static int GetIntensityCalculator( int drinkStrengh)
    {
        int qty;
        switch (drinkStrengh)
        {
            case <= 1:
                qty = 2;
                break;
            case > 1 and <= 3:
                qty = 2;
                break;
            default:
                qty = 3;
                break;
        }

        return qty;
    }
}