using Module2HW3.Models.Vegetables;

namespace Module2HW3.Provider.Abstactions
{
    public interface IVegetablesProvider
    {
        public Vegetable[] GetAllVegetables();
    }
}
