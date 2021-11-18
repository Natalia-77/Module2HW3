using Module2HW3.Models.Vegetables;

namespace Module2HW3.Services.Abstarctions
{
    public interface ISaladFindName
    {
        public Vegetable[] FindVegetables(Vegetable[] vegetables, string name);
    }
}
