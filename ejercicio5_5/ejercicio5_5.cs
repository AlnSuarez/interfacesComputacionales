using System;

class ejercicio5_5
{
    static void Main()
    {
        int n = 10;
        float [] arreglo = new float[n];

        Console.WriteLine("\nEjercicio resuelto 5_5\n");
        for(int i=0;i<n;i++)
        {
            Console.WriteLine("introduzca el elemento {0} de la lista", i+1);
            float elem = float.Parse(Console.ReadLine());
            arreglo[i] = elem;
        }

        Console.Write("Los elementos de la lista son:");
        for(int i=0;i<n;i++){
            Console.Write(arreglo[i]+"\t");
        }
        float menor =arreglo[0];
        float mayor =arreglo[0];
        float media=0;

        for(int i=0;i<n;i++){
            if(menor>arreglo[i])menor=arreglo[i];
            if(mayor<arreglo[i])mayor=arreglo[i];
            media = (media+arreglo[i]);
        }

        media = media/n;
        Console.WriteLine("el menor es {0}", menor);
        Console.WriteLine("el mayor es {0}", mayor);
        Console.WriteLine("la media es {0}", media);


        

    }
}