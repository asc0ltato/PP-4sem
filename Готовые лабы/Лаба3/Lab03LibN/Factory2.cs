namespace Lec03LibN
{
    internal class Factory2 : IFactory
    {
        public float a = 0;
        public Factory2(float a)
        {
            this.a = a;
        }
        public IBonus GetA(float cost1Hour)
        {
            return new L2A(cost1Hour, a);
        }

        public IBonus GetB(float cost1Hour, float x)
        {
            return new L2B(cost1Hour, a, x);
        }

        public IBonus GetC(float cost1Hour, float x, float y)
        {
            return new L2C(cost1Hour, a, x, y);
        }
    }
}
