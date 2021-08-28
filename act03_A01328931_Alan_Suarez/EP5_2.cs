using System;

class EP5_2
{
    static void Main()
    {
        //programa que crea un arreglo que contiene numeros aleatorios
        //despues de haberlos creado pregunta al usuario la existencia de
        //un numero para revisarlo en la lista.
        Random r = new Random();
        int flag = 0;
        Console.Write("Dame el tamaño de la lista: ");
        int numeroLista = Int32.Parse(Console.ReadLine());
        int [] arreglo = new int[numeroLista];


        for(int i = 0; i<numeroLista; i++)
        {
            
            int aleatorio = r.Next(0,9);
            Console.WriteLine(aleatorio);
            arreglo[i] = aleatorio;
        }

        Console.Write("Introduce un numero para encontrarlo: ");
        int variableABuscar = Int32.Parse(Console.ReadLine());

    
        for(int i = 0; i<numeroLista; i++)
        {
            if(arreglo[i]==variableABuscar)
            {   
                Console.WriteLine("Se encuentra en la posición {0} del arreglo", i+1);
                break;
            }
            flag = i;
        }
        if(flag == numeroLista-1)
        {
            Console.WriteLine("no se encuentra en el arreglo");
        }


        

    }
}