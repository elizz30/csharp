// // //DECLARACION Y USO DE VARIABLES

// // // mostrar un mensaje en la consola
// void MostrarMensaje()
// {
//     Console.WriteLine("Hello, te amo messi!");
// }

// // //LLamar una variable
// void LlamarVariable()
// {
//     string aFriend = "jaime";
//     Console.WriteLine(aFriend);

//     aFriend = "nacho";
//     Console.WriteLine("Hello, " + aFriend);
// }

// // //llamar una variable con interpolacion
// void LlamarVariableInterpolacion()
// {
//     string aFriend = "jaime";
//     Console.WriteLine($"Hello, {aFriend}, mi amigo de toda la infancia.");
// }

// // //OPERACIONES CON CADENAS

// void OperacionesConCadenas()
// {
//     string firstFriend = "Alisson";
//     string SecondFriend = "Daniel";

//     Console.WriteLine($"Mis amigos son {firstFriend} y {SecondFriend}");
// }

// // //Length
// void Length()
// {
//     string firstFriend = "Alisson";
//     string SecondFriend = "Daniel";
//     Console.WriteLine($"El nombre de mi amigo es: {firstFriend} y tiene {firstFriend.Length} letras.");
//     Console.WriteLine($"El nombre de mi segundo amigo es: {SecondFriend} y tiene {SecondFriend.Length} letras.");
// }

// // //necesito ir practicando para que se me guarde en la cabeza, no es tan dificil, solo es cuestion de acostumbrarse a escribirlo y entenderlo.

// // //ELIMINAR ESPACIOS EN BLANCO DE CADENAS
// void EliminarEspacios()
// {
//     string greeting = "   hello world!       ";
//     Console.WriteLine($"[{greeting}]");

//     string trimmedGreeting = greeting.TrimStart();
//     Console.WriteLine($"[{trimmedGreeting}]");

//     trimmedGreeting = greeting.TrimEnd();
//     Console.WriteLine($"[{trimmedGreeting}]");

//     trimmedGreeting = greeting.Trim();
//     Console.WriteLine($"[{trimmedGreeting}]");
// }

//BUSCAR Y REEMPLAZAR EN CADENAS

/* void buscarYReemplazar()
{
    string sayHello = "Hello WorlD!";
    Console.WriteLine(sayHello);

    sayHello = sayHello.Replace("Hello", "CaMBio");
    Console.WriteLine(sayHello);

    Console.WriteLine(sayHello.ToUpper());
    Console.WriteLine(sayHello.ToLower());

    string songLyrics = "You say Goodbye, and I say Mamichula";
    Console.WriteLine(songLyrics.Contains("Mamichula"));
    Console.WriteLine(songLyrics.Contains("Pedro Sanchez"));

} */

//DESAFIO de buscar y reemplazar en cadenas

/* void desafioTexto()
{

    string songLyrics = "You say Goodbye, and I say Mamichula";
    Console.WriteLine(songLyrics.StartsWith("You"));
    Console.WriteLine(songLyrics.StartsWith("goodbye"));

    Console.WriteLine(songLyrics.EndsWith("Mamichula"));
    Console.WriteLine(songLyrics.EndsWith("goodbye"));

}

desafioTexto();

 */

/*/REPASO DE TEXTO
 COSAS A REPASAR:

 -mostrar un mensaje en la consola
 -mostrar un mensaje en la consola
 -llamar una variable con interpolacion
 -OPERACIONES CON CADENAS
 -LENGTH
 -ELIMINAR ESPACIOS
 -BUSCAR Y REEMPLAZAR
 -  */

//1. mostrar un mensaje en la consola
void repaso1()
{
    Console.WriteLine(
        """
        Estoy que me muero de sueño, pero quiero seguir aprendiendo a programar, asi que vamos a darle!
        "(ya no agunto mas, me voy a dormir)"
        """
    );

    // Console.WriteLine("Estoy que me muero de sueño, pero quiero seguir aprendiendo a programar, asi que vamos a darle!");
}

repaso1();
