

/* void tuplas()
{

    var pt = (X: 1, Y: 2);

    var sople = (double)pt.Y / pt.X;

    //modificar elemento de la tupla
    pt.X = pt.X + 5;

    //crear copia y modificar la copia
    var pt2 = pt with { Y = 10 };

    Console.ReadKey();
    Console.WriteLine($"El punto ahora está en: {pt}");
    Console.ReadKey();
    Console.WriteLine($"Una linea del punto de origen al punto {pt} tiene una pendiente de {sople} ");
    Console.ReadKey();
    Console.WriteLine($"El punto pt2 está en: {pt2}");

    var suscrip = (A: 0, B: 0);
    suscrip = pt;
    Console.ReadKey();
    Console.WriteLine(suscrip);

    var nameData = (Name: "Observacion diurna", temp: 17, Wind: 4);
    var person = (FirsName: "Elias", Lastname: "");
    var order = (Producto: "Guitarra", estilo: "Acustica", cantidad: 500, UnitPrice: 0.10m);

    Console.ReadKey();
    Console.WriteLine($"Datos de la observacion: {nameData.Name}, {nameData.temp}°C, viento a {nameData.Wind} km/h");
    Console.ReadKey();
    Console.WriteLine($"Datos de la persona: {person.FirsName} {person.Lastname}");
    Console.ReadKey();
    Console.WriteLine($"Datos del pedido: {order.Producto}, {order.estilo}, cantidad: {order.cantidad}, precio unitario: {order.UnitPrice}");
}
 */
// tuplas();


// Point pt3 = new Point(1, 1);
// var pt4 = pt3 with { Y = 10 };
// double slopeResult = pt4.Slope();
// Console.WriteLine($"La pendiente de {pt4} es: {slopeResult}");
// Console.ReadKey();
// Console.WriteLine($"Los dos puntos están: {pt3} y {pt4}");

/*EJERCICIOS DE GEMINI 
  Reto: Llama al método ObtenerCoordenadas() y guarda únicamente la latitud y 
  la longitud en variables individuales, ignorando la población.*/

/* void ejer1()
{
    (double Lat, double Lon, int Poblacion) ObtenerCoordenadas()
    {
        return (9.928, -84.090, 340000);
    }


    var co = ObtenerCoordenadas();
    Console.WriteLine($"la latitud es: {co.Lat} y la longitud es: {co.Lon}");


} */

//lo hice mal, tenia que ignorar la población, no guardarla en una variable, pero bueno, el resultado es correcto (usando el _ para ignorar la variable)

//ejer3 (ni lo hice pq no sé nada todavia de LINQ y tampoco se me ocurria como hacerlo con un bucle, pero lo dejo aquí para que lo veas)
/* (int Pares, int Impares) ContarParesEImpares(List<int> numeros)
{
    int pares = numeros.Count(n => n % 2 == 0);
    int impares = numeros.Count - pares;

    return (pares, impares);
}

// Uso:
var conteo = ContarParesEImpares(new List<int> { 1, 2, 3, 4, 5 });
Console.WriteLine($"Pares: {conteo.Pares}, Impares: {conteo.Impares}");
// Imprime: Pares: 2, Impares: 3
 */

/* public record struct Point(int X, int Y)
{
    public double Slope() => (double)Y / (double)X;
}

 */