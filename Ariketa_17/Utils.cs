static class Utils
{
    public static int[,] CreateMatrix(int dimensions, bool DefaultValues = false)
    {
        var rnd = new Random();
        var matrix = new int[dimensions, dimensions];
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (DefaultValues)
                    matrix[i, j] = 0;
                else
                    matrix[i, j] = rnd.Next(1, 9);

        return matrix;
    }

    public static void DisplayMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write($"{matrix[i, j]} ");
            Console.WriteLine();
        }
    }
    
    public static int[,] SumMatrixes(int dimension, params int[][,] matrixes)
    {
        var resultMatrix = CreateMatrix(dimension, true);

        foreach (var matrix in matrixes)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    resultMatrix [i,j] += matrix[i, j];

        }

        return resultMatrix;
    }
}