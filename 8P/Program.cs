using _8P.Ejecucion;
using _8P.Piezas;

Reina reina = new Reina();
Torre torre = new Torre();
Alfil alfil = new Alfil();
Peon peon = new Peon();
Caballo caballo = new Caballo();
Ejec nuevaJug = new Ejec(reina);

if (nuevaJug.nuevaEjec())
{
    Console.WriteLine("Solución encontrada para Pieza " + reina.nombrePieza);
    Console.WriteLine("");
    nuevaJug.ImprimirTablero();
}
else
{
    Console.WriteLine("No se encontró una solución.");
}