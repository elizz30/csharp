//EXPLORACION DE LOS ENTEROS

void OperacionSencilla()
{

    //SUMA
    int a = 5;
    int b = 3;
    int c = a + b;
    Console.WriteLine(c);

    //RESTA
    int d = a - b;
    Console.WriteLine(d);

    //MULTIPLICACION
    int e = a * b;
    Console.WriteLine(e);

    //DIVISION
    int f = a / b;
    Console.WriteLine(f);

}

// OperacionSencilla();


void OperacionMixtas()
{
    int a = 5;
    int b = 3;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    int e = (a + b) * c;
    Console.WriteLine(e);

    int f = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(f);

}

// OperacionMixtas();


//LIMITES  Y PRECISION DE LOS ENTEROS

void limitesEnteros()
{
    // int a = 7;
    // int b = 4;
    // int c = 3;
    // int d = (a + b) / c;
    // int e = (a + b) % c;
    // Console.WriteLine($"El resultado de la division es: {d}");
    // Console.WriteLine($"El residuo de la division es: {e}");


    // int max = int.MaxValue;
    // int min = int.MinValue;

    // Console.WriteLine($"El limites del int son: {min} y {max}");

    // int boff = max + 3;
    // Console.WriteLine($"An example of overflow is: {boff}");
}


//OPERACION CON DOUBLE

void QueFacilidad()
{
    string mensaje = "MIRE QUE FACIL ERA HACER UN METODO, GRAN CABALLO";
    Console.WriteLine(mensaje);
}

// QueFacilidad();

/* DIA #2 LEYENDO LA DOCUMENTACION DE MICROSOFT (APENAS VOY POR LOS NUMEROS) PERO POCO A POCO SE MEJORA, 
CONFIE QUE AL FINAL DE AÑO LE VAN A DAR LA NOTICIA DE QUE SE PUEDE QUEDAR EN 
LA EMPRESA POR SU BUEN DESEMPEÑO, ASI QUE A SEGUIR PRACTICANDO Y MEJORANDO. */

void TipoDouble()
{
    double a = 5;
    double b = 4;
    double c = 2;
    double d = (a + b) / c;
    Console.WriteLine(d);

    double max = double.MaxValue;
    double min = double.MinValue;

    Console.WriteLine($"EL minimo de double es: {min} y el maximo es: {max}");

    double third = 1.0 / 3.0;
    Console.WriteLine(third);
}

/* TipoDouble(); */

void WorkWhitDouble()
{
    double a = 29;
    double b = 4554;
    double c = 4;
    double d = (b * c) + a / a;
    Console.WriteLine(d);

}

/* WorkWhitDouble(); */

//TRABAJAR CON DECIMALES

void TipoDecimal()
{
    decimal max = decimal.MaxValue;
    decimal min = decimal.MinValue;
    Console.WriteLine($" Los limites del tipo de dato decimal son: {max} y {min}");

    decimal a = 1.0M;
    decimal b = 3.0M;
    Console.WriteLine(a / b);
}

/* TipoDecimal(); */

//DESAFIO
/* Ahora que conoce los diferentes tipos numéricos, escriba código que calcule el área de un círculo cuyo radio sea de 2,50 centímetros. 
Recuerde que el área de un círculo es el radio cuadrado multiplicado por PI. Una sugerencia: el tiempo de ejecución contiene una constante 
para PI, Math.PI que puede usar para ese valor. Math.PI, como todas las constantes declaradas en el espacio de nombres System.Math, es un valor double.
 Por ese motivo, debe usar double en lugar de valores decimal para este desafío. */

void desafio()
{
    double radio = 2.50;
    double area = Math.PI * radio * radio;
    Console.WriteLine($"El resultado es: {area}");
}

desafio();