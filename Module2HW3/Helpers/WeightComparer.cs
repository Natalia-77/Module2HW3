using System;
using System.Collections.Generic;
using Module2HW3.Models.Vegetables;

namespace Module2HW3.Helpers
{
    public class WeightComparer : IComparer<Vegetable>
    {
        public int Compare(Vegetable first, Vegetable second)
        {
            if (first.Weight > second.Weight)
            {
                return 1;
            }
            else if (first.Weight < second.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
