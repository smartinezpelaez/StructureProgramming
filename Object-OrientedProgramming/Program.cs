using Object_OrientedProgramming.Busines;
using System.Threading.Channels;

Beer coronaBeer = new Beer("corona", 10, -2, 1000);

var poker = new ExpiringBeer("Poker", 15, 6, new DateTime(2026, 04, 01), 300);

//Drink drink = new Beer("Aguila", 3, 4,  1000);//Viene de la clase abstracta

Drink drinkWine = new Wine(750);
Show(drinkWine);

Drink drink = new Wine(500);
Show(drink);
drink = new Beer("Cruz campo", 6, 7, 330);
Show(drink);

var services = new Service(100, 10);

ISalable[] concepts = [
    coronaBeer,
    poker,
    services
];

Console.WriteLine("Total concepts: " + GetTotal(concepts));

void Show(Drink drink) => Console.WriteLine(drink.GetCategory());

SendSome(coronaBeer);

var elements = new Colletion<int>(3);
elements.Add(1);
elements.Add(2);
elements.Add(3);
elements.Add(4);
foreach (var element in elements.Get())
{
    Console.WriteLine(element);
}

var names = new Colletion<string>(2);
names.Add("Steven");
names.Add("Thiago");
names.Add("vane");
foreach (var name in names.Get())
{
    Console.WriteLine(name);
}

var beers = new Colletion<Beer>(2);
beers.Add(coronaBeer);
beers.Add(poker);
foreach (var beer in beers.Get())
{
    Console.WriteLine(beer.GetInfo());
}

Console.WriteLine($"Objetos creados : {Beer.QuantityObjects}");
Console.WriteLine($"Operación estatico suma: {Operations.Add(4,4)}");
Console.WriteLine($"Operación estatico Multiplicación: {Operations.Mul(5, 4)}");

void SendSome(ISend some)
{
    Console.WriteLine("Haga algo");
    some.Send();
    Console.WriteLine("Haga algo más");
}

decimal GetTotal(ISalable[] concepts)
{ 
    decimal total = 0;
    foreach (var concept in concepts)
    {
        total += concept.GetPrice();
    }

    return total;

}
