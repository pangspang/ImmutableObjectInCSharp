namespace ImmutableObjectInCSharp.Classes;

public class ImmutableTestObject
{
    public readonly string Property;

    //programming error: this should be readonly
    public string Immutable { get; private set; }

    public ImmutableTestObject(string property, string immutable)
    {
        Property = property;
        Immutable = immutable;
    }

    public ImmutableTestObject SetMutable(string immutable)
    {
        //programming error
        Immutable = immutable;

        return new ImmutableTestObject(Property, immutable);
    }
}