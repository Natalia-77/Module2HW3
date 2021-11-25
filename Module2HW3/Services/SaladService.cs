using System;
using Module2HW3.Helpers;
using Module2HW3.Models;
using Module2HW3.Models.Vegetables;
using Module2HW3.Services.Abstarctions;

namespace Module2HW3.Services
{
    public class SaladService : ISaladServices
    {
        private readonly CaloriesComparer _caloriesComparer;
        private readonly WeightComparer _weightComparer;
        private Vegetable[] _vegetables;
        private Salad _salad;

        public SaladService()
        {
            _caloriesComparer = new CaloriesComparer();
            _weightComparer = new WeightComparer();
            _vegetables = new Vegetable[0];
        }

        public int Calories()
        {
            var calories = 0;
            foreach (var item in _vegetables)
            {
                calories += item.Calories;
            }

            return calories;
        }

        public Salad MakeSalad(string name, Vegetable[] vegetables)
        {
            if (vegetables.Length > 1)
            {
                _salad = new Salad()
                {
                    Name = name,
                    Vegetables = vegetables
                };
                _vegetables = _salad.Vegetables;

                return _salad;
            }

            return null;
        }

        public void SortByCalories()
        {
            Array.Sort(_vegetables, _caloriesComparer);
        }

        public void SortByWeight()
        {
            Array.Sort(_vegetables, _weightComparer);
        }
    }
}
