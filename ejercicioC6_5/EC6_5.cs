using System;

namespace EC6_5
{
    class Program
    {   //Este metodo determina si n es primo 
            //entrada es un numero entero mayor que cero
            //Salida: true si es primo, false si no lo es.
        static void Main()
        {
            
            int numero;
            Console.WriteLine("\n **ejercicio resuelto 6_5**\n");
            do
            {
                //repite lectura de numero hasta que sea mayor a 0
                Console.WriteLine("escribe un numero entero mayor a 0");
                numero = Int32.Parse(Console.ReadLine());
            }while(numero <= 0);

            Console.WriteLine("Los primos menores que {0} son: ", numero);
            for(int i = 1; i<numero; i++){
                if(Primo(i)==true){
                    Console.WriteLine(i);
                }
            }
        }

        static bool Primo(int n)
        {
            for(int m=2; m<n;m++)
            {
                if(n%m ==0)
                {
                    return false;
                }
                return true;
            }
        }
    }
}



