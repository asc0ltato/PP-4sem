﻿namespace Lec03LibN
{
    internal class L3A : IBonus
    {
        public L3A(float cost1hour, float a, float b)
        {
            this.cost1hour = cost1hour;
            this.a = a;
            this.b = b;
        }
        float a = 0.0f;
        float b = 0.0f;
        public float cost1hour { get; set; } = 0;
        public float calc(float number_hours)
        {
            return (number_hours + a) * (cost1hour + b);
        }
    }
}
