/*
Console.WriteLine("Bienvenidos a mi primer programa en C# poco de hijueputas");

const string MyConst = "Juan";


Console.WriteLine("Hola " + MyConst);

*/

var MyDic = new Dictionary <string, int>
{
    {"Salchipapas", 1600},
    {"Nova Suprema", 3200},
    {"Taco Tico", 1500}
};

Console.WriteLine("Que desea llevar?");
Console.ReadLine();
Console.WriteLine(MyDic["Salchipapas"]);