

void pendiente()
{

    var pt = (X: 1, Y: 2);

    var sople = (double)pt.Y / pt.X;

    pt.X = pt.X + 5;

    Console.ReadKey();
    Console.WriteLine($"El punto ahora está en: {pt}");
    Console.ReadKey();
    Console.WriteLine($"Una linea del punto de origen al punto {pt} tiene una pendiente de {sople} ");
}

pendiente();

