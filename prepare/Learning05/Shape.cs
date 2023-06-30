public class Shape
{
    private string color;

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public Shape(string color)
    {
        this.color = color;
    }

    public virtual double GetArea()
    {
        return 0; // Implementación base, debe ser sobrescrita por las clases derivadas
    }
}