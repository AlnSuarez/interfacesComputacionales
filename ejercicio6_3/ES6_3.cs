using System;
//namespace es un conjunto de clases 
namespace ES6_3
{
    class Program
    {
        // este metodo devuelve el mayor de los numeros dados
        //entrada: tres numeros dados 
        // salida el numero mayor

        static void Main()
        {
            int num1, num2, num3;

            Console.WriteLine("\n**ejercicio resuelto 6-3**");
            Console.Write("escribe el primer numero: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Escribe el segundo numero: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.Write("Escribe el tercer numero: ");
            num3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("El mayor es" + Mayor(num1,num2,num3));
            
        }

        static int Mayor(int a, int b, int c)
        {
            if(a > b)
            {
                if(a>c)
                    return a;
                else
                    return c;

            }
            else
                if(b>c)
                    return b;
                else    
                    return c;
        }
    }
}