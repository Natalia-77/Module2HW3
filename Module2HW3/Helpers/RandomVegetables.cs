using System;
using Module2HW3.Models.Vegetables;

namespace Module2HW3.Helpers
{
    public class RandomVegetables
    {
        public Vegetable[] GetRandomVegetables(int size, Vegetable[] vegetables)
        {
            if (size <= 1 || vegetables.Length <= 1)
            {
                return null;
            }
            else
            {
                var random = new Random();
                var randomvegetable = new Vegetable[size];
                for (var i = 0; i < size; i++)
                {
                    randomvegetable[i] = vegetables[random.Next(0, vegetables.Length)];
                }

                return randomvegetable;
            }
        }
    }
}
