namespace ImmutableObjectInCSharp.Records;

public record MutableRecord(string Property)
{
    public string Property = Property;
}