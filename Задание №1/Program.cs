List<IAnimal> myAnimals = new List<IAnimal>();
myAnimals.Add(new Dog());
myAnimals.Add(new Cat());
myAnimals.Add(new Owl());
myAnimals.Add(new Pig());
myAnimals.Add(new Cow());

foreach (IAnimal animal in myAnimals)
{
    PetAnimal(animal);
}

Console.ReadKey(true);

static void PetAnimal(IAnimal animal)
{
    Console.WriteLine("мы гладим зверюшку, а она нам говорит:");
    animal.Voice();
}
interface IAnimal
{
    void Voice();
}
class Dog : IAnimal { public void Voice() { Console.WriteLine("Гав!"); } }
class Cat : IAnimal { public void Voice() { Console.WriteLine("Мяу!"); } }
class Owl : IAnimal
{
    private int GetCurrentTime()
    {
        try { return Convert.ToInt32(File.ReadAllText("current_time.txt")); }
        catch { return 0; }
    }
    public void Voice()
    {
        int currentTime = GetCurrentTime();
        if ((currentTime >= 8) && (currentTime <= 21))
        {
            Console.WriteLine("Тисе, я сплю");
        }
        else { Console.WriteLine("Ух! Ух! Ух!"); }
    }

}
class Pig : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Хрю");
    }
}
class Cow : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Му");
    }
}