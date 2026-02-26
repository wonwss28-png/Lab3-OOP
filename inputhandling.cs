// InputHandler class
using System;

public class InputHandler
{
    public  Matrix InputMatrix()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine()!);
        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine()!);

        Matrix matrix = new Matrix(rows, cols);

        Console.WriteLine("Enter matrix values:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Value at ({i}, {j}): ");
                double val = double.Parse(Console.ReadLine()!);
                matrix.SetValue(i, j, val);
            }
        }

        return matrix;
    }

    public Vector InputVector()
    {
        Console.Write("Enter vector size: ");
        int size = int.Parse(Console.ReadLine()!);

        Vector vector = new Vector(size);

        Console.WriteLine("Enter vector values:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Value at index {i}: ");
            double val = double.Parse(Console.ReadLine()!);
            vector.SetValue(i, val);
        }

        return vector;
    }
}