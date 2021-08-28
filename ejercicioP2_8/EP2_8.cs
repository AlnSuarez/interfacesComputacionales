using System;


class EP2_8
{
    static void Main()
    {
        bool equilatero = false;

        Console.Write("Escriba el lado 1 ");
        int lado1 = Int32.Parse(Console.ReadLine());
        Console.Write("Escriba el lado 2 ");
        int lado2 = Int32.Parse(Console.ReadLine());
        Console.Write("Escriba el lado 3 ");
        int lado3 = Int32.Parse(Console.ReadLine());

        int sumadelados = lado1+lado2;

        if(sumadelados > lado3)
        {
            if(lado1!=lado2&&lado2!=lado3&&lado3!=lado1)
            {
                Console.WriteLine("El triangulo es escaleno");
            }
            if(lado1==lado2&&lado2==lado3&&lado3==lado1)
            {
                Console.WriteLine("El triangulo es equilatero");
                equilatero= true;
            }
            if(lado1==lado2||lado2==lado3||lado3==lado1){
                if(equilatero==false)
                {
                    Console.WriteLine("El triangulo es isóseles");
                }
                
            }
        }

    }

}