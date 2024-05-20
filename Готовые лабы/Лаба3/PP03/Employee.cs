using Lec03LibN;

public class Employee
{
    public IBonus Bonus { get; private set; }
    public Employee(IBonus bonus)
    {
        this.Bonus = bonus;
    }
    public float CalcBonus(float numberHours)
    {
        return Bonus.calc(numberHours);
    }
}