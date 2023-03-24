List<IHello> Greetings = new List<IHello>();
Greetings.Add(new Eng());
Greetings.Add(new Spn());
Greetings.Add(new Frh());
Greetings.Add(new Ger());
Greetings.Add(new Itl());
foreach (IHello lang in Greetings)
{
    lang.SayHello();
}
Console.ReadKey(true);
interface IHello
{
    void SayHello();
}

class Eng : IHello { public void SayHello() { Console.WriteLine("Hello!"); } }
class Spn : IHello { public void SayHello() { Console.WriteLine("Hola!"); } }
class Frh : IHello { public void SayHello() { Console.WriteLine("Bonjour!"); } }
class Ger : IHello { public void SayHello() { Console.WriteLine("Hallo!"); } }
class Itl : IHello { public void SayHello() { Console.WriteLine("Ciao!"); } }