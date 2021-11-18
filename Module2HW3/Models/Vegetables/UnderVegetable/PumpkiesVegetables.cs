using Module2HW3.Config.Enums;

namespace Module2HW3.Models.Vegetables.UnderVegetable
{
    /// <summary>
    /// Vegetables->Generative->PumpkiesVegetables.
    /// Подгруппа тыквенные.
    /// </summary>
   public abstract class PumpkiesVegetables : Generative
    {
        public PumpkiesVegetables()
        {
           Season = GrowingSeason.Medium;
        }
    }
}
