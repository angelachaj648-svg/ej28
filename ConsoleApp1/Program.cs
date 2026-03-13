
static void PromedioCalificaciones()
{
	double suma = 0;

	for (int i = 1; i <= 3; i++)
	{
		Console.Write("Calificacion " + i + ": ");
		suma += Double.Parse(Console.ReadLine());
	}

	Console.WriteLine("Promedio: " + (suma / 3));
}


