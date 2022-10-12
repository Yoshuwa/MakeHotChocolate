using System;

namespace YoshuwaKalangu;

public class Ingredients
{

    public int addChocolateBeans(int Qty)
    {
        if (Qty <= 0) throw new ArgumentOutOfRangeException(nameof(Qty));
        return Qty;
    }

}