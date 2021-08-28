using System;

class EP5_12
{
    static void Main()
    {
        Console.Write("Dame el indice 1: ");
        int uno = Int32.Parse(Console.ReadLine());
        Console.Write("Dame el indice 2: ");
        int dos = Int32.Parse(Console.ReadLine());
        Console.Write("Dame el indice 3: ");
        int tres = Int32.Parse(Console.ReadLine());
        
        int [,,] tabla = new int[uno+1,dos+1,tres+1];
        for(int i=0; i<=uno;i++)
        {
             for(int j=0; j<=uno;j++)
             {
                 for(int k=0; k<=uno;k++)
                 {  
                     
                    tabla[i,j,k] = i+j+k;
                 }
             }
        }

        

        for(int i=0; i<=uno;i++){
            for(int j=0; j<=dos; j++){
                for(int k=0; k<=tres; k++){
                    Console.WriteLine("tabla[{0},{1},{2}]: {3}", i,j,k, tabla[i,j,k]);
                }
            }
        }
    }
}