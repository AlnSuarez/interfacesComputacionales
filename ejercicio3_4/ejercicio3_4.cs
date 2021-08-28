using System;

class ejercicio3_4
{
    static void Main(){
        int numero;

        Random r = new Random();
        int num_secreto = r.Next(10);

        Console.WriteLine("\n** Ejercicio resuelto 3-4 **\n");

        Console.WriteLine("Adivina mi numero secreto entre 0 y 9");
        Console.WriteLine("Escribe tu numero: ");
        numero = int.Parse(Console.ReadLine());
        if(numero == num_secreto)
        {
            Console.WriteLine("enhorabuena");

        }
        else
        {

            Console.WriteLine("Lo siento");
        }

        Console.WriteLine("Mi numero secreto era: "+num_secreto);
    }
}