public class Reference
{
    public string Value { get; }

    public Reference(string value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return Value;
    }
}
