using System;

class Ejercicio4_11
{
    static void Main()
    {
        bool par;
        int n;
        par = true;

        Console.WriteLine("\n** EJERCICIO RESUELTo 4-11 **\n");
        Console.WriteLine("introduzca los datos de una secuencia");
        Console.WriteLine("de numeros positivos");
        Console.WriteLine("Utilice 0 para señalar el fin de secuencia");
        n = Int32.Parse(Console.ReadLine());
        while(n!=0 && par)
        {
            par = n%2 ==0;
            if(par)
                n= Int32.Parse(Console.ReadLine());
        }
        if(par)
        {
            Console.WriteLine("Secuencia de pares");
        }
        else
        {

            Console.WriteLine("No es secuencia de pares");
        }
        

    }
}