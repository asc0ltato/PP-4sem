namespace Lab1
{
    public class C1
    {
        private const int Age1 = 18;
        public const int Age2 = 18;
        protected const int Age3 = 19;

        private string? name1;
        public string? name2;
        protected string? name3;

        private string? Name1 { get; set; }
        public string? Name2 { get; set; }
        protected string? Name3 { get; set; }

        public C1() { }

        public C1(C1 prev)
        {
            Name1 = prev.Name1;
            Name2 = prev.Name2;
            Name3 = prev.Name3;
        }

        public C1(string name1, string name2, string name3)
        {
            Name1 = name1;
            Name2 = name2;
            Name3 = name3;
        }

        private void ReturnName1()
        {
            Console.WriteLine($"Имя 1 = {Name1}");
        }

        public void ReturnName2()
        {
            Console.WriteLine($"Имя 2 = {Name2}");
        }

        protected void ReturnName3()
        {
            Console.WriteLine($"Имя 3 = {Name3}");
        }

        public void State()
        {
            Console.WriteLine($"Имя 1 = {Name1} | Имя 2 = {Name2} | Имя 3 = {Name3}");
        }

        public override string ToString()
        {
            return Name1 + " " + Name2 + " " + Name3;
        }
    }
}