<<<<<<< HEAD

public class DimensionValidator
{
    public bool ValidateMatrixAddition(Matrix A, Matrix B)
    {
        return A.Rows == B.Rows && A.Cols == B.Cols;
    }

    public bool ValidateVectorAddition(Vector A, Vector B)
    {
        return A.Size == B.Size;
    }
=======

public class DimensionValidator
{
    public bool ValidateMatrixAddition(Matrix A, Matrix B)
    {
        return A.Rows == B.Rows && A.Cols == B.Cols;
    }

    public bool ValidateVectorAddition(Vector A, Vector B)
    {
        return A.Size == B.Size;
    }
>>>>>>> 8592ef2cc9f386bc16b3e4f74fe59f39dcfc33ef
}