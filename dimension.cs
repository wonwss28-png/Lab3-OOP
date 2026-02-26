
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
}