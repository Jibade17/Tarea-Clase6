int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);


var contador = 0;
int numero = 0;

do
{
    contador++;

    Console.WriteLine("Ingrese un número");
    numero = int.Parse(Console.ReadLine());
    
    if (numero == numeroSecreto)
    {
        Console.WriteLine("Felicitaciones, has adivinado el número que era: " + numeroSecreto);
        Console.WriteLine("Lo has logrado en " + contador + " intentos.");
    }
    else if (numero > numeroSecreto)
    { 
        Console.WriteLine("El numero es menor");
    }
    else
    {
        Console.WriteLine("El numero es mayor");
    }
}
while ( numero != numeroSecreto);


