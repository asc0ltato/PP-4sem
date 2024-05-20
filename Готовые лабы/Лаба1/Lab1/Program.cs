namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-------------1 задание------------");
            C1 c1 = new C1("Лиза","Снежана","Лера");
            C1 c2 = new C1(c1);
            C1 c3 = new C1();

            Console.WriteLine($"Конструктор с параметрами: {c1}");
            Console.WriteLine($"Конструктор копирования: {c2}");
            Console.WriteLine($"Конструктор по умолчанию: {c3}");

            //Console.WriteLine(C1.Age1);
            Console.WriteLine(C1.Age2);
            //Console.WriteLine(C1.Age3);

            //Console.WriteLine(c1.Name1);
            Console.WriteLine(c1.Name2);
            //Console.WriteLine(c1.Name3);

            //c1.ReturnName1()
            c1.ReturnName2();
            //c1.ReturnName3();

            c1.State();
            c1.Name2 = "Света";
            c1.State();

            Console.WriteLine("\n-------------2 задание------------");

            C2 c4 = new C2();
            c4.ReturnNameEvent += c4.ReturnNames;
            c4.FirstName("Настя");
            c4.SecName("Аня");

            C2 c5 = new C2("Влад","Дима","Ринат");
            C2 c6 = new C2(c5);

            Console.WriteLine(c5.ToString());

            //Console.WriteLine(C2.Age1);
            Console.WriteLine(C2.Age2);
            //Console.WriteLine(C2.Age3);

            //Console.WriteLine(c2names.Name1);
            Console.WriteLine(c5.Name2);
            //Console.WriteLine(c2names.Name3);

            //c2names.ReturnName1();
            c5.ReturnName2();
            //c2names.ReturnName3();

            c5.State();
            c5.Name2 = "Ксюша";
            c5.State();

            Console.WriteLine("\n-------------3 задание------------");

            Parrot popug = new Parrot("Попугай", 3);
            Console.WriteLine(popug.ToString());
            popug.PoPug();
            popug.Popug("Привет, попугай!");
        }
    }
}