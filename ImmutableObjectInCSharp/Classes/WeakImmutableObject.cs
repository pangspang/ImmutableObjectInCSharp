namespace ImmutableObjectInCSharp.Classes;

public class WeakImmutableObject
{
    public readonly string Property;

    public string Mutable { get; set; }

    public WeakImmutableObject(string property, string mutable)
    {
        Property = property;
        Mutable = mutable;
    }
}