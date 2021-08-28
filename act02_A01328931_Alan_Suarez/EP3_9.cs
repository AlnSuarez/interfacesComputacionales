using System;

class EP3_9
{
    static void Main()
    {
        Console.Write("Escriba el angulo");
        double grados = Double.Parse(Console.ReadLine());;
        double radianes = grados * Math.PI / 180.0;
        Console.WriteLine("seno es: {0}", Math.Sin(radianes));
        double sin = Math.Sin(radianes);
        if(sin>0.01745240&&sin<=1)
        {
            Console.WriteLine("El seno es positivo");
        }else if(sin<-0.01745240&&sin>=-1)
        {
            Console.WriteLine("El seno es negativo");
        }
        else{
            Console.WriteLine("El seno es cero");
        }

        // sin>-0.0174524064372844&&sin<-1
    }
}