using Module2HW3.Models.Vegetables;
using Module2HW3.Services.Abstarctions;

namespace Module2HW3.Services
{
    public class ServiceFindName : ISaladFindName
    {
        public Vegetable[] FindVegetables(Vegetable[] vegetables, string name)
        {
            var index = 0;
            var findvegetable = new Vegetable[vegetables.Length];

            for (var i = 0; i < vegetables.Length; i++)
            {
                if (vegetables[i].Name == name || vegetables[i].Name.ToLower() == name)
                {
                    findvegetable[index++] = vegetables[i];
                    break;
                }
                else
                {
                    i++;
                }
            }

            return findvegetable;
        }
    }
}
