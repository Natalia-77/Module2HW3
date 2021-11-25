using Module2HW3.Config.Enums;

namespace Module2HW3.Models.Vegetables.UnderVegetable
{
    /// <summary>
    /// Vegetables->Generative->SeedsVegetables.
    /// Подгруппа зерно-бобовые.
    /// </summary>
    public abstract class SeedsVegetables : Generative
    {
        public SeedsVegetables()
        {
            Season = GrowingSeason.Late;
        }
    }
}
