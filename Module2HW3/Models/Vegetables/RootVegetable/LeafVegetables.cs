using Module2HW3.Config.Enums;

namespace Module2HW3.Models.Vegetables.RootVegetable
{
    /// <summary>
    ///  Vegetable->Vegetative->LeafVegetables.
    ///  Листовые.
    /// </summary>
    public abstract class LeafVegetables : Vegetative
    {
        public LeafVegetables()
        {
            Duration = DurationGrown.ManyYear;
        }
    }
}
