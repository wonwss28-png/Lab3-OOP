<<<<<<< HEAD
// VectorCalculator class
public class VectorCalculator
{
    private DimensionValidator validator;

    public VectorCalculator(DimensionValidator validator)
    {
        this.validator = validator;
    }

    public Vector Add(Vector A, Vector B)
    {
        if (!validator.ValidateVectorAddition(A, B))
        {
            throw new InvalidOperationException("Vector sizes do not match.");
        }

        int size = A.Size;
        Vector result = new Vector(size);

        for (int i = 0; i < size; i++)
        {
            result.SetValue(i, A.GetValue(i) + B.GetValue(i));
        }

        return result;
    }
=======
// VectorCalculator class
public class VectorCalculator
{
    private DimensionValidator validator;

    public VectorCalculator(DimensionValidator validator)
    {
        this.validator = validator;
    }

    public Vector Add(Vector A, Vector B)
    {
        if (!validator.ValidateVectorAddition(A, B))
        {
            throw new InvalidOperationException("Vector sizes do not match.");
        }

        int size = A.Size;
        Vector result = new Vector(size);

        for (int i = 0; i < size; i++)
        {
            result.SetValue(i, A.GetValue(i) + B.GetValue(i));
        }

        return result;
    }
>>>>>>> 8592ef2cc9f386bc16b3e4f74fe59f39dcfc33ef
}