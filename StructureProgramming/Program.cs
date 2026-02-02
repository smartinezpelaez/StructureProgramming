int limit = 10;
var beers = new string[limit];
int iBeers = 0;
int opcion = 0;

do
{
    try
    {
        Console.Clear();
        Showmenu();
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                if (iBeers < limit)
                {
                    InputBeer();
                }
                else
                {
                    Console.WriteLine("Ya no caben cervesas");
                }

                break;
            case 2:
                ShowBeers(beers, iBeers);

                break;
            case 3:
                Console.WriteLine("Chaolin");
                break;
            default:
                Console.WriteLine("numero invalido");
                break;

        }
    }
    catch (Exception ex) 
    {
        Console.WriteLine("ingreso una tecla invalida" + ex);
    }
   
}
while (opcion != 3);

void Showmenu()
{
    Console.WriteLine("1. Agregar nombre: ");
    Console.WriteLine("2. Mostrar nombre: ");
    Console.WriteLine("3. salir");
}

void InputBeer()
{
    Console.Clear();
    Console.WriteLine("Escriba un nombre para la cervesa");
    var beer = Console.ReadLine();
    beers[iBeers] = beer;
    iBeers++;
}

void ShowBeers(string[] beers, int iBeers)
{
    Console.Clear();
    Console.WriteLine("--------Cervesas---------");
    for (int i = 0;  i<= iBeers ;i ++)
    {
        Console.WriteLine(beers[i]);
    }
    Console.WriteLine("-------------------------");
    Console.WriteLine("Presiona una tecla para continuar");
    Console.ReadLine();
}
