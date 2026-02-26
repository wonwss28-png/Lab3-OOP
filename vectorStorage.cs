<<<<<<< HEAD
// VectorRepository class
using System.Collections.Generic;

public class VectorRepository
{
    private List<Vector> vectors = new List<Vector>();

    public void AddVector(Vector v)
    {
        vectors.Add(v);
    }

    public Vector GetVector(int index)
    {
        if (index < 0 || index >= vectors.Count)
            throw new IndexOutOfRangeException("Invalid vector index.");

        return vectors[index];
    }
=======
2// VectorRepository class
using System.Collections.Generic;

public class VectorRepository
{
    private List<Vector> vectors = new List<Vector>();

    public void AddVector(Vector v)
    {
        vectors.Add(v);
    }

    public Vector GetVector(int index)
    {
        if (index < 0 || index >= vectors.Count)
            throw new IndexOutOfRangeException("Invalid vector index.");

        return vectors[index];
    }
>>>>>>> 8592ef2cc9f386bc16b3e4f74fe59f39dcfc33ef
}