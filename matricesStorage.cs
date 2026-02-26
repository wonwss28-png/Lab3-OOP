<<<<<<< HEAD
// MatrixRepository class
using System.Collections.Generic;

public class MatrixRepository
{
    private List<Matrix> matrices = new List<Matrix>();

    public void AddMatrix(Matrix m)
    {
        matrices.Add(m);
    }

    public Matrix GetMatrix(int index)
    {
        if (index < 0 || index >= matrices.Count)
            throw new IndexOutOfRangeException("Invalid matrix index.");

        return matrices[index];
    }
=======
// MatrixRepository class
using System.Collections.Generic;

public class MatrixRepository
{
    private List<Matrix> matrices = new List<Matrix>();

    public void AddMatrix(Matrix m)
    {
        matrices.Add(m);
    }

    public Matrix GetMatrix(int index)
    {
        if (index < 0 || index >= matrices.Count)
            throw new IndexOutOfRangeException("Invalid matrix index.");

        return matrices[index];
    }
>>>>>>> 8592ef2cc9f386bc16b3e4f74fe59f39dcfc33ef
}