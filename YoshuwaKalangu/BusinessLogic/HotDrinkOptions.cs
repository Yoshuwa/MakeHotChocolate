namespace YoshuwaKalangu;

public class HotDrinkOptions
{
    public static void MakeHotBeverage(string userInput)
    {
        // future dev, make this dynamic
        switch (userInput)
        {
            case "Cappuccino":
                Cappucino.MakeCappucino(5);
                break;
            case "Hot Chocolate":
                Latte.HotChoc(5);
                break;
            case "Latte":
                Latte.MakeLatte(5);
                break;
            default:
                HotBeverageMaker.notAvailable(userInput);
                break;
        }
    }
}