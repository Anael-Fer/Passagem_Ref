using System;

class Program
{

    static bool MatrizIdentidade(int[,] matriz)
    {

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                // Verifica se a diagonal principal é 1 e os outros elementos são 0
                if ((i == j && matriz[i, j] != 1) || (i != j && matriz[i, j] != 0))
                {
                    return false;
                }
            }

        }

        return true;
    }
    static void Main()
    {
        int[,] matriz = {
            { 1, 0, 0, 0 },
            { 0, 1, 0, 0 },
            { 0, 0, 1, 0 },
            { 0, 0, 0, 1 }
        };

        bool resultado = MatrizIdentidade(matriz);
        Console.WriteLine("A matriz é identidade? " + resultado);
    }


}
