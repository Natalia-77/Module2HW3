using Module2HW3.Helpers;
using Module2HW3.Provider;
using Module2HW3.Services;

namespace Module2HW3
{
    public class Starter
    {
        private readonly SaladService _saladService;
        private readonly VegetableProvider _vegetableProvider;
        private readonly RandomVegetables _randomVegetables;
        private readonly ServiceFindName _findItemService;

        public Starter()
        {
            _saladService = new SaladService();
            _vegetableProvider = new VegetableProvider();
            _randomVegetables = new RandomVegetables();
            _findItemService = new ServiceFindName();
        }

        public void Run()
        {
            var vegetables = _vegetableProvider.GetAllVegetables();
            var randomfill = _randomVegetables.GetRandomVegetables(3, vegetables);
            _saladService.MakeSalad("Vitamin", randomfill);
            _findItemService.FindVegetables(randomfill, "Bianco angel");
            _saladService.SortByCalories();
            _saladService.SortByWeight();
            _saladService.Calories();
        }
    }
}
