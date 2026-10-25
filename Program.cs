
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

//Punto4: Dos listas paralelas
string[] nombres = { "Alexander", "Romina", "Timmy", "Elsa" };
int[] edades = { 20, 24, 18, 22 };
Console.WriteLine("Escribe el nombre a consultar:");
string nombreBuscado = Console.ReadLine();

int pos = Array.IndexOf(nombres, nombreBuscado);
if (pos != -1)
{
    Console.WriteLine($"{nombres[pos]} --> {edades[pos]}");
}
else
{
    Console.WriteLine($"{nombreBuscado} no se encontró ");
}
//Punto 5:Estructura combinada
string[,] usuarios =
{
    { "Luis", "luis@correo.com", "Cusco" },
    { "María", "maria@correo.com", "Lima" },
    { "Ana", "ana@correo.com", "Lima" },
    { "Carlos", "carlos@correo.com", "Arequipa" },
    { "Beatriz", "beatriz@correo.com", "Trujillo" }
};
int filas = 5;
int columnas = 3;

Console.WriteLine("Lista de usuarios:");
MostrarUsuarios(usuarios, filas);

//Punto6: Búsqueda textual por ciudad
Console.WriteLine("Escribe la ciudad a buscar:");
string ciudadBuscada = Console.ReadLine();
BuscarPorCiudad(usuarios, filas, ciudadBuscada);

//Punto7: Ordenar alfabéticamente los nombres
OrdenarPorNombre(usuarios, filas, columnas);
Console.WriteLine("Usuarios ordenados alfabéticamente:");
MostrarUsuarios(usuarios, filas);

static void MostrarUsuarios(string[,] usuarios, int filas)
{
    for (int i = 0; i < filas; i++)
    {
        Console.WriteLine($"{i + 1}. Nombre: {usuarios[i, 0]} | Email: {usuarios[i, 1]} | Ciudad: {usuarios[i, 2]}");
    }
}

static void BuscarPorCiudad(string[,] usuarios, int filas, string ciudad)
{
    int coincidencias = 0;
    for (int i = 0; i < filas; i++)
    {
        // Normalizamos ambos textos en minúsculas antes de comparar
        if (usuarios[i, 2].ToLower().IndexOf(ciudad.ToLower()) != -1)
        {
            Console.WriteLine($"Nombre: {usuarios[i, 0]} | Email: {usuarios[i, 1]} | Ciudad: {usuarios[i, 2]}");
            coincidencias++;
        }
    }
     if (coincidencias == 0)
    {
        Console.WriteLine($"No hay usuarios en {ciudad}");
    }
    else
    {
        Console.WriteLine($"Coincidencias encontradas: {coincidencias}");
    }
}
static void OrdenarPorNombre(string[,] usuarios, int filas, int columnas)
{
    for (int pasada = 0; pasada < filas - 1; pasada++)
    {
        for (int i = 0; i < filas - 1 - pasada; i++)
        {
            if (usuarios[i, 0].CompareTo(usuarios[i + 1, 0]) > 0)
            {
                
                for (int c = 0; c < columnas; c++)
                {
                    string temp = usuarios[i, c];
                    usuarios[i, c] = usuarios[i + 1, c];
                    usuarios[i + 1, c] = temp;
                }
            }
        }
    }
}