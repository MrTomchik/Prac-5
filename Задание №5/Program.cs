List<IWiz> Wizardry = new List<IWiz>();
Wizardry.Add(new Magician(50, "Гарик"));
Wizardry.Add(new Magician(30, "Анджела"));
Wizardry.Add(new Magician(60, "Гандам"));
foreach (IWiz cast in Wizardry)
{
    cast.spell();
}

Console.ReadKey(true);

interface IWiz
{
    void spell();
}
class Magician : IWiz
{
    public int Mana { get; set; }
    public string Name { get; set; }
    public Magician(int mana, string name)
    {
        Mana = mana;
        Name = name;
    }
    // public  Magician(string Name, int Mana) { }
    public void spell()
    {
        int mana = 40;
        if (Mana >= mana)
        {
            Console.WriteLine(Name + " шаманит!");
            Mana -= mana;
        }
        else
        {
            Console.WriteLine("Для испольования заклинания не хватает " + (Math.Abs(mana - Mana)) + " единиц маны. " + Name + " бездействует!");
        }
    }
}
