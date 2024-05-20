namespace Lab1
{
    class Parrot : Bird
    {
        new public string? animalName;
        public int animalAge;

        new public string? AnimalName { get => animalName; }
        public int AnimalAge { get => animalAge; }

        public Parrot(string userAnimalName, int userAnimalAge) : base(userAnimalName)
        {
            animalName = userAnimalName;
            animalAge = userAnimalAge;
        }

        public override string ToString()
        {
            return animalClass + "\nИмя: " + animalName + "\nВозраст: " + animalAge + "\n" + Legs;
        }

        public void PoPug()
        {
            Console.WriteLine("Parrot");
        }
    }
}