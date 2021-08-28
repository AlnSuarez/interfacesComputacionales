using System;

class EP5_1
{
    static void Main()
    {
        //programa que escribe la dimension de cada una de las matrices.
        int[] tabla1 = new int [2];
        int[,] tabla2 = new int [2,2];
        int[,,] tabla3 = new int[2,2,2];
        int[,,,]tabla4 = new int[2,2,2,2];
        Console.WriteLine("Dimension de tabla: {0}", tabla1.Rank);
        Console.WriteLine("Dimension de tabla: {0}", tabla2.Rank);
        Console.WriteLine("Dimension de tabla: {0}", tabla3.Rank);
        Console.WriteLine("Dimension de tabla: {0}", tabla4.Rank);
    }
}