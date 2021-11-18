using Module2HW3.Config.Enums;

namespace Module2HW3.Models.Vegetables.RootVegetable
{
    /// <summary>
    /// Vegetable->Vegetative->CabbageVegetables.
    /// Подгруппа капустных.
    /// </summary>
    public abstract class CabbageVegetables : Vegetative
    {
        public CabbageVegetables()
        {
            Duration = DurationGrown.TwoYear;
        }
    }
}
