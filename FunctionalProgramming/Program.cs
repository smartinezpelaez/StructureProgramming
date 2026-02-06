
//Console.WriteLine(Tomorrow());
//Console.WriteLine(TomorrowPure(new DateTime(2026, 02, 05,00, 00, 00)));

//var beer = new Beer()
//{
//    Name = "Heiniken",
//};

//Console.WriteLine(ToUpperPure(beer).Name);
//Console.WriteLine($"No se modifica el original por eso es pura: {beer.Name}");


//Console.WriteLine(ToUpper(beer).Name);
//Console.WriteLine($"Se modifica el original por eso es no pura: {beer.Name}");

var t = TomorrowPure;
Console.WriteLine(t(new DateTime(2026,02,05,0,0,0)));

Action<string> show = Console.WriteLine;
show("Hola");

Action<string> hi = name => Console.WriteLine($"Hola {name}");
hi("Steven");

Action<int, int> add = (a, b) => show((a + b).ToString());
add(9, 7);

Func<int, int, decimal> mul = (a, b) => a * b;
show(mul(4, 9).ToString());

Func<int, int, string> multString = (a, b) =>
{
    var res = a * b;
    return res.ToString();
};
show(multString(5, 4));

List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
var number2 = Filter(numbers, numbers => numbers % 2 == 0);
foreach (var number in number2)
{
    Console.WriteLine(number);
}

var number3 = Filter(numbers, numbers => numbers % 2 == 1);
foreach (var number in number3)
{
    Console.WriteLine(number);
}


List<int> Filter(List<int> list, Func<int, bool> condition)
{ 
    var resulList = new List<int>();
    foreach (var element in list)
    {
        if (condition(element))
        {
            resulList.Add(element);
        }
    }
    return resulList;
    
}

Predicate<int> condition1 = x => x%2 == 0;
Predicate<int> condition2 = x => x>5;

var number4 = FilterPredicate(numbers, condition1);

foreach (var number in number4)
{
    Console.WriteLine(number);
}


List<int> FilterPredicate(List<int> list, Predicate<int> condition)
{
    var resulList = new List<int>();
    foreach (var element in list)
    {
        if (condition(element))
        {
            resulList.Add(element);
        }
    }
    return resulList;

}

//Función no pura
DateTime Tomorrow()
{ 
    return DateTime.Now.AddDays(1);
}

Beer ToUpper (Beer beer)
{ 
    beer.Name = beer.Name.ToUpper();
    return beer;
    
}

//Función pura
DateTime TomorrowPure(DateTime date)
{
    return date.AddDays(1);
}

Beer ToUpperPure(Beer beer)
{
    var beer2 = new Beer()
    {
        Name = beer.Name.ToUpper(),
    };
    return beer2;
}


//Parametros
public class Beer
{
    public string Name { get; set; }
}