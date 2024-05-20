namespace Lec03LibN
{
    internal class L2A : IBonus
    {
        public L2A(float cost1hour, float a)
        {
            this.cost1hour = cost1hour;
            this.a = a;
        }
        public float a = 0.0f;
        public float cost1hour { get; set; } = 0;
        public float calc(float number_hours)
        {
            return (number_hours + a) * cost1hour;
        }
    }
}
