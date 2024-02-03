Console.WriteLine();



int numero;

Console.Write("Introduzca un numero entero positivo: ");

numero = int.Parse(Console.ReadLine());

while (numero > 0)

{
    Console.Write("Introduzca un numero entero positivo: ");

    numero = int.Parse(Console.ReadLine());
}

Console.WriteLine("ha introducido un numero entero negativo. Fijate bien mamaguevo.");