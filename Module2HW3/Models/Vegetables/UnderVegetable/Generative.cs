using Module2HW3.Config.Enums;

namespace Module2HW3.Models.Vegetables.UnderVegetable
{
    /// <summary>
    /// Генеративные(плоды и соцветия).Все,кроме корнеплодов.
    /// </summary>
    public abstract class Generative : Vegetable
    {
        public Generative()
        {
            Type = ComplexType.Generative;
        }
    }
}
