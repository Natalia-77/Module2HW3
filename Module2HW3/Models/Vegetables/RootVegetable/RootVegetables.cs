using Module2HW3.Config.Enums;

namespace Module2HW3.Models.Vegetables.RootVegetable
{
    /// <summary>
    /// Vegetable->Vegetative->RootVegetable.
    /// Корнеплоды.
    /// </summary>
    public abstract class RootVegetables : Vegetative
    {
        public RootVegetables()
        {
            Duration = DurationGrown.OneYear;
        }
    }
}
