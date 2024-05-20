namespace Lec03LibN
{
    public interface IFactory
    {
        IBonus GetA(float cost1Hour);
        IBonus GetB(float cost1Hour, float x);
        IBonus GetC(float cost1Hour, float x, float y);
    }
}
