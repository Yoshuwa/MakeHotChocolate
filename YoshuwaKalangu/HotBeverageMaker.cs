using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoshuwaKalangu
{
    public class HotBeverageMaker
    {
        private readonly HotChocolate HotChocolate;
        private static Latte Latte;

        public HotBeverageMaker()
        {
            HotChocolate = new HotChocolate(this);
            Latte = new Latte(this);
            Ingredients1 = new Ingredients();
        }

        public Ingredients Ingredients1 { get; }

        public static void notAvailable(string drink)
        {
            Console.WriteLine($"{drink} not available:(");
        }
    }
}
