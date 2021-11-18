using Module2HW3.Config.Enums;

namespace Module2HW3.Models.Vegetables
{
    public abstract class Vegetable
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Calories { get; set; }
        public ComplexType Type { get; set; }
        public DurationGrown Duration { get; set; }
        public GrowingSeason Season { get; set; }
    }
}
