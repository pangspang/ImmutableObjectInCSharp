namespace ImmutableObjectInCSharp.Classes;

public class ValueEqualityImmutableObject
{
    public readonly string Property;
    public readonly string OtherProperty;

    public ValueEqualityImmutableObject(string property, string otherProperty)
    {
        Property = property;
        OtherProperty = otherProperty;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null && obj is not ValueEqualityImmutableObject)
            return false;

        var other = obj as ValueEqualityImmutableObject;
        
        return Property == other.Property && OtherProperty == other.OtherProperty;   
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Property, OtherProperty);
    }
}