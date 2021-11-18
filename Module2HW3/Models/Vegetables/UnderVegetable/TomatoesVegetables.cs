using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Models.Vegetables.UnderVegetable
{
    /// <summary>
    /// Vegetables->Generative->TomatoesVegetables.
    /// Подгруппа томатные.
    /// </summary>
    public abstract class TomatoesVegetables : Generative
    {
        public TomatoesVegetables()
        {
            Season = Config.Enums.GrowingSeason.Medium;
        }
    }
}
