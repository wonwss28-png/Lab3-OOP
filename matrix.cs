<<<<<<< HEAD


public class Matrix
{
    private int rows;
    private int cols;
    private Row[] rowData;

    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;

        rowData = new Row[rows];
        for (int i = 0; i < rows; i++)
        {
            rowData[i] = new Row(cols);
        }
    }

    public double getValue(int i,int j)
    {
        return rowData[i].getValue(j);
    }
    public void SetValue(int i, int j, double value)
    {
        rowData[i].setValue(j, value);
    }
    public void Display()
    {
        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(getValue(i, j) + "\t");
            }
            Console.WriteLine();
        }
    }
    public int Rows => rows;
    public int Cols => cols;
=======


public class Matrix
{
    private int rows;
    private int cols;
    private Row[] rowData;

    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;

        rowData = new Row[rows];
        for (int i = 0; i < rows; i++)
        {
            rowData[i] = new Row(cols);
        }
    }

    public double getValue(int i,int j)
    {
        return rowData[i].getValue(j);
    }
    public void SetValue(int i, int j, double value)
    {
        rowData[i].setValue(j, value);
    }
    public void Display()
    {
        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(getValue(i, j) + "\t");
            }
            Console.WriteLine();
        }
    }
    public int Rows => rows;
    public int Cols => cols;
>>>>>>> 8592ef2cc9f386bc16b3e4f74fe59f39dcfc33ef
}