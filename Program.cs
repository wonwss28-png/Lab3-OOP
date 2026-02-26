using System;

class Program
{
    static void Main(string[] args)
    {
       InputHandler input = new InputHandler();
       Console.WriteLine("Enter a matrix number:");
       Matrix userMatrix = input.InputMatrix();
       Console.WriteLine("You entered the following matrix:");
       userMatrix.Display();
       Console.WriteLine("\nEnter a vector number:");
       Vector userVector = input.InputVector();
       Console.WriteLine("You entered the following vector:");
       userVector.Display();
       InputHandler inputHandler = new InputHandler();
       DimensionValidator validator = new DimensionValidator();

       MatrixCalculator matrixCalc = new MatrixCalculator(validator);
       VectorCalculator vectorCalc = new VectorCalculator(validator);

       MatrixRepository matrixRepo = new MatrixRepository();
       VectorRepository vectorRepo = new VectorRepository();

    // Create matrices using InputHandler
       Matrix m1 = inputHandler.InputMatrix();
       Matrix m2 = inputHandler.InputMatrix();

       matrixRepo.AddMatrix(m1);
       matrixRepo.AddMatrix(m2);

    // Perform matrix addition
       Matrix resultMatrix = matrixCalc.Add(m1, m2);

       Console.WriteLine("Matrix Addition Result:");
       resultMatrix.Display();

    // Create vectors
       Vector v1 = inputHandler.InputVector();
       Vector v2 = inputHandler.InputVector();

       vectorRepo.AddVector(v1);
       vectorRepo.AddVector(v2);

    // Perform vector addition
       Vector resultVector = vectorCalc.Add(v1, v2);

       Console.WriteLine("Vector Addition Result:");
       resultVector.Display();
    }
}