namespace Lab1
{
    class Bird
    {
        public const string animalClass = "Птица";
        public string animalName;
        private string Wings = "Крылья";
        protected string Legs = "Ножки";

        public string? AnimalName { get => animalName; }

        public Bird (string userAnimalName)
        {
            animalName = userAnimalName;
        }

        public void Popug(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}