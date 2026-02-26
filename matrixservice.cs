<<<<<<< HEAD

public class MatrixCalculator
{
    private DimensionValidator validator;

    public MatrixCalculator(DimensionValidator validator)
    {
        this.validator = validator;
    }

    public Matrix Add(Matrix A, Matrix B)
   
    {
        if (!validator.ValidateMatrixAddition(A, B))
        {
            throw new InvalidOperationException("Matrix dimensions do not match.");
        }

        int rows = A.Rows;
        int cols = A.Cols;
        Matrix result = new Matrix(rows, cols);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result.SetValue(i, j, A.getValue(i, j) + B.getValue(i, j));
            }
        }

        return result;
    }
=======

public class MatrixCalculator
{
    private DimensionValidator validator;

    public MatrixCalculator(DimensionValidator validator)
    {
        this.validator = validator;
    }

    public Matrix Add(Matrix A, Matrix B)
   
    {
        if (!validator.ValidateMatrixAddition(A, B))
        {
            throw new InvalidOperationException("Matrix dimensions do not match.");
        }

        int rows = A.Rows;
        int cols = A.Cols;
        Matrix result = new Matrix(rows, cols);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result.SetValue(i, j, A.getValue(i, j) + B.getValue(i, j));
            }
        }

        return result;
    }
>>>>>>> 8592ef2cc9f386bc16b3e4f74fe59f39dcfc33ef
}