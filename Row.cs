<<<<<<< HEAD
public class Row
{
    private double[] values;

    public Row(int size)
    {
        values = new double[size];
    }

    public double getValue(int i)
    {
        return values[i];
    }

    public void setValue(int i, double value)
    {
        values[i] = value;
    }

    public int length()
    {
        return values.Length;
    }
=======
public class Row
{
    private double[] values;

    public Row(int size)
    {
        values = new double[size];
    }

    public double getValue(int i)
    {
        return values[i];
    }

    public void setValue(int i, double value)
    {
        values[i] = value;
    }

    public int length()
    {
        return values.Length;
    }
>>>>>>> 8592ef2cc9f386bc16b3e4f74fe59f39dcfc33ef
}