using Module2HW3.Config.Enums;
using Module2HW3.Models.Vegetables;
using Module2HW3.Models.Vegetables.RootVegetable;
using Module2HW3.Models.Vegetables.UnderVegetable;
using Module2HW3.Provider.Abstactions;

namespace Module2HW3.Provider
{
    public class VegetableProvider : IVegetablesProvider
    {
        public Vegetable[] GetAllVegetables()
        {
            var vegetable = new Vegetable[]
            {
                new Melon()
                {
                    Name = "While Lili",
                    Calories = 78,
                    Weight = 500,
                    MelonType = MelonType.Lili
                },
                new Tomato()
                {
                    Name = "Black prince",
                    Calories = 20,
                    Weight = 50,
                    TomatoType = TomatoType.Black
                },
                new Pepper()
                {
                    Name = "Spicy one",
                    Calories = 120,
                    Weight = 85,
                    PepperType = PepperType.Spicy
                },
                new Broccoli()
                {
                    Name = "Fortuna lotereya",
                    Calories = 40,
                    Weight = 63,
                    BroccoliType = BroccoliType.Fortuna
                },
                new Beetroot()
                {
                    Name = "Detroit monster",
                    Calories = 25,
                    Weight = 110,
                    BeetrootType = BeetrootType.Detroit
                },
                new Carrot()
                {
                    Name = "Amsterdam sun",
                    Calories = 40,
                    Weight = 150,
                    CarrotType = CarrotType.Amsterdam
                },
                new Garlic()
                {
                    Name = "Bianco angel",
                    Calories = 20,
                    Weight = 20,
                    GarlicType = GarlicType.Bianco
                },
                new Onion()
                {
                    Name = "Everest mountain",
                    Calories = 30,
                    Weight = 110,
                    OnionType = OnionType.Everest
                }
            };
            return vegetable;
        }
    }
}
