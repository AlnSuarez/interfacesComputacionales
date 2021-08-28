using System;

class EP4_8
{
    static void Main()
    {
        int intentos = 1;
        Console.Write("Escriba su usuario ");
        Console.ReadLine();
        Console.Write("Escriba su contraseña ");
        Console.ReadLine();
        Console.WriteLine("Clave ha caducado, introduzca nueva clave");
        string password = Console.ReadLine();
        Console.WriteLine("Confirme nueva clave");
        string clave = Console.ReadLine();
        while(clave != password)
        {
            if(intentos==5){
                Console.WriteLine("Contraseña incorrecta, usuario bloqueado");
                break;
            }
            Console.WriteLine("Por favor escriba la contraseña de nuevo");
            clave = Console.ReadLine();
            
            if(clave==password){
                Console.WriteLine("Cambio exitoso");
            }
    
            intentos++;
        }




    }
}