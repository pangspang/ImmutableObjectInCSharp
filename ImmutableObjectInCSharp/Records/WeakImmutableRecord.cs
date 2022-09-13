namespace ImmutableObjectInCSharp.Records;

public record WeakImmutableRecord(string First, string Last)
{
    public string Last { get; set; } = Last;
}