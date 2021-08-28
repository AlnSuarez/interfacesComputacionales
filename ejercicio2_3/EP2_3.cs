// pag 38

using System;

class ejercicio2_3
{

    static void Main(){
        int a,b,c, suma = 0;
        float media = 0;

        Console.WriteLine("\n ** Ejercicio Resuelto 2-2 **\n");
        Console.Write("Escribe el primer valor: ");
        a = Int32.Parse(Console.ReadLine());

        Console.Write("Escribe el segundo valor: ");
        b = Int32.Parse(Console.ReadLine());
        Console.Write("Escribe el tercer valor: ");
        c = Int32.Parse(Console.ReadLine());

        suma = a+b+c;
        media = (float)suma /3;
        Console.WriteLine("la suma es: "+suma);
        Console.WriteLine("la media es: "+ media);
    }
    
}