namespace Lec03LibN
{
    internal class Factory3 : IFactory
    {
        public float a = 0;
        public float b = 0;
        public Factory3(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public IBonus GetA(float cost1Hour)
        {
            return new L3A(cost1Hour, a, b);
        }

        public IBonus GetB(float cost1Hour, float x)
        {
            return new L3B(cost1Hour, a, b, x);
        }

        public IBonus GetC(float cost1Hour, float x, float y)
        {
            return new L3C(cost1Hour, a, b, x, y);
        }
    }
}
