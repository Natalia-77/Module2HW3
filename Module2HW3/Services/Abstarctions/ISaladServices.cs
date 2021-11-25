using Module2HW3.Models;
using Module2HW3.Models.Vegetables;

namespace Module2HW3.Services.Abstarctions
{
    public interface ISaladServices
    {
        public Salad MakeSalad(string name, Vegetable[] vegetables);
        public void SortByWeight();
        public void SortByCalories();
    }
}
