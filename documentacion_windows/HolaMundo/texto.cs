// //DECLARACION Y USO DE VARIABLES

// // mostrar un mensaje en la consola
// Console.WriteLine("Hello, te amo messi!");


// //LLamar una variable
// string aFriend = "jaime";
// Console.WriteLine(aFriend);

// aFriend = "nacho";
// Console.WriteLine("Hello, " + aFriend);

// //llamar una variable con interpolacion
// Console.WriteLine($"Hello, {aFriend}, mi amigo de toda la infancia.");


// //OPERACIONES CON CADENAS

// string firstFriend = "Alisson";
// string SecondFriend = "Daniel";

// Console.WriteLine($"Mis amigos son {firstFriend} y {SecondFriend}");

// //Length
// Console.WriteLine($"El nombre de mi amigo es: {firstFriend} y tiene {firstFriend.Length} letras.");
// Console.WriteLine($"El nombre de mi segundo amigo es: {SecondFriend} y tiene {SecondFriend.Length} letras.");

// //necesito ir practicando para que se me guarde en la cabeza, no es tan dificil, solo es cuestion de acostumbrarse a escribirlo y entenderlo.

// //ELIMINAR ESPACIOS EN BLANCO DE CADENAS

// string greeting = "   hello world!       ";
// Console.WriteLine($"[{greeting}]");

// string trimmedGreeting = greeting.TrimStart();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.TrimEnd();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.Trim();
// Console.WriteLine($"[{trimmedGreeting}]");


//BUSCAR Y REEMPLAZAR EN CADENAS

// string sayHello = "Hello WorlD!";
// Console.WriteLine(sayHello);

// sayHello = sayHello.Replace("Hello", "CaMBio");
// Console.WriteLine(sayHello);

// Console.WriteLine(sayHello.ToUpper());
// Console.WriteLine(sayHello.ToLower());

// string songLyrics = "You say Goodbye, and I say Mamichula";
// Console.WriteLine(songLyrics.Contains("Mamichula"));
// Console.WriteLine(songLyrics.Contains("Pedro Sanchez"));


//DESAFIO de buscar y reemplazar en cadenas

// string songLyrics = "You say Goodbye, and I say Mamichula";
// Console.WriteLine(songLyrics.StartsWith("You"));
// Console.WriteLine(songLyrics.StartsWith("goodbye"));

