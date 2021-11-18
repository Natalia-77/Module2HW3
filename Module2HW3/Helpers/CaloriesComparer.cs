using System.Collections.Generic;
using Module2HW3.Models.Vegetables;

namespace Module2HW3.Helpers
{
    public class CaloriesComparer : IComparer<Vegetable>
    {
        public int Compare(Vegetable first, Vegetable second)
        {
            if (first.Calories > second.Calories)
            {
                return 1;
            }
            else if (first.Calories < second.Calories)
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
