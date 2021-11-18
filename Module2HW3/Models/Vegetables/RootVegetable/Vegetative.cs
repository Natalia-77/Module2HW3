using Module2HW3.Config.Enums;

namespace Module2HW3.Models.Vegetables.RootVegetable
{
    /// <summary>
    /// Вегетативные овощи(клубни).
    /// </summary>
    public abstract class Vegetative : Vegetable
    {
        public Vegetative()
        {
            Type = ComplexType.Vegetative;
        }
    }
}
