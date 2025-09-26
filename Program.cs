// See https://aka.ms/new-console-template for more information

using Ejercicio1Clase3;

Estudiante e1 = new Estudiante("Heather", 24);
Estudiante e2 = new Estudiante();


Console.WriteLine(e1.getNombre());
Console.WriteLine(e2.getNombre());

e1.Reir();
e2.Reir();

String rspta = e1.cantar("");
Console.WriteLine(rspta);

rspta = e2.cantar("Macarena");
Console.WriteLine(rspta);

Estudiante e3 = new Estudiante();
e3.setNombre("Andres");

Console.WriteLine(e3.getNombre());