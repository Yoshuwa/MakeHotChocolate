namespace YoshuwaKalangu;

public class HotChocolate
{
    private HotBeverageMaker _hotBeverageMaker;

    public HotChocolate(HotBeverageMaker hotBeverageMaker)
    {
        _hotBeverageMaker = hotBeverageMaker;
    }

    private void MakeHotChocolate(int intensity)
    {
        Instructions.PourWater(4);
        _hotBeverageMaker.Ingredients1.addChocolateBeans(2);
        Instructions.addMilk(2);
        Instructions.addSugar(5);
    }
}