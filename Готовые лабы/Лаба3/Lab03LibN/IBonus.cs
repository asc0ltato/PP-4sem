namespace Lec03LibN
{
    public interface IBonus
    {
        float cost1hour { get; set; }
        float calc(float numberHours);
    }
}
