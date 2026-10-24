
string oracion ="Los personajes de Sanrio son My Melody,Hello Kitty,Kuromi y Cinamonroll.";

//Obtener subcadena My Melody

string palabra=oracion.Substring(29,9);
Console.WriteLine(palabra);

//Buscar palabra : Sanrio
int buscartext=oracion.IndexOf("Sanrio");
Console.WriteLine(buscartext);
//Reemplazar a My Melody por Pochacco
string reemplazo=oracion.Replace("My Melody","Pochacco");
Console.WriteLine(reemplazo);

//Dvidir usando Split
string[] dividir=oracion.Split(',');
for (int i=0;i<dividir.Length;i++)
{
    Console.WriteLine($"Parte{i+1}:{dividir[i]}");
}