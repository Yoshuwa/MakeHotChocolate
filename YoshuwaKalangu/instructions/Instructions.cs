using System;

namespace YoshuwaKalangu;

public class Instructions
{
    public static int addSugar(int Qty)
    {
        if (Qty <= 0) throw new ArgumentOutOfRangeException(nameof(Qty));
        return Qty;
    }

    public static int addMilk(int Qty)
    {
        if (Qty <= 0) throw new ArgumentOutOfRangeException(nameof(Qty));
        return Qty;
    }

    public static int PourWater(int Qty)
    {
        if (Qty <= 0) throw new ArgumentOutOfRangeException(nameof(Qty));
        return Qty;
    }
    public int addChocolateBeans(int Qty)
    {
        if (Qty <= 0) throw new ArgumentOutOfRangeException(nameof(Qty));
        return Qty;
    }

    public static int addBeans(int Qty)
    {
        if (Qty <= 0) throw new ArgumentOutOfRangeException(nameof(Qty));
        return Qty;
    }
}