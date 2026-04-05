/*
Console.WriteLine("Bienvenidos a mi primer programa en C# poco de hijueputas");

const string MyConst = "Juan";


Console.WriteLine("Hola " + MyConst);

*/

var MyDic = new Dictionary<string, int>
{
    {"Salchipapas", 1600},
    {"Nova Suprema", 3200},
    {"Taco Tico", 1500}
};

Console.WriteLine("Que desea llevar?");

dynamic respuesta = Console.ReadLine();
if (respuesta == "Salchipapas")
{
    Console.WriteLine("El precio de las Salchipapas es: " + MyDic["Salchipapas"]);
}
else if (respuesta == "Nova Suprema")
{
    Console.WriteLine("El precio de la Nova Suprema es: " + MyDic["Nova Suprema"]);
}
else if (respuesta == "Taco Tico")
{
    Console.WriteLine("El precio del Taco Tico es: " + MyDic["Taco Tico"]);
}
else
{
    Console.WriteLine("No tenemos ese producto, gracias por su visita");
}