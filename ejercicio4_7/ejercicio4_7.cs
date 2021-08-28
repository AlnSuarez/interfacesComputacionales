using System;

class ejecicio4_7{
    static void Main()
    {
        int dato;
        Console.WriteLine("introduzca un numero entero mayor que cero");
        dato = Int32.Parse(Console.ReadLine());
        Console.WriteLine("x\t2x\tx^2\tsqrt(x");
        Console.WriteLine("-\t--\t---\t------");
        for(int i = 1; i<=dato;i++)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3:###.###}",i,2*i,Math.Pow(i,2),Math.Sqrt(i));
        }
    }
}