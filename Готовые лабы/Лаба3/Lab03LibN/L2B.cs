﻿namespace Lec03LibN
{
    internal class L2B : IBonus
    {
        public L2B(float cost1hour, float a, float x)
        {
            this.cost1hour = cost1hour;
            this.a = a;
            this.x = x;
        }
        public float a = 0.0f;
        public float cost1hour { get; set; } = 0;
        public float x { get; set; } = 0;
        public float calc(float number_hours)
        {
            return (number_hours + a) * cost1hour * x;
        }
    }
}
