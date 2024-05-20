namespace Lec03LibN
{
    internal class Factory1 : IFactory
    {
        public IBonus GetA(float cost1Hour)
        {
            return new L1A(cost1Hour);
        }

        public IBonus GetB(float cost1Hour, float x)
        {
            return new L1B(cost1Hour, x);
        }

        public IBonus GetC(float cost1Hour, float x, float y)
        {
            return new L1C(cost1Hour, x, y);
        }
    }
}
