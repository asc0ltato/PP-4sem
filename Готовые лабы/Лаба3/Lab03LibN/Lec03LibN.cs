namespace Lec03LibN
{
    public static partial class Lec03BLib
    {
        static public IFactory GetL1()
        {
            return new Factory1();
        }
        static public IFactory GetL2(float a)
        {
            return new Factory2(a);
        }
        static public IFactory GetL3(float a, float b)
        {
            return new Factory3(a, b);
        }
    }
}
