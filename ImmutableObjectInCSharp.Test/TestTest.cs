using ImmutableObjectInCSharp.Classes;
using ImmutableObjectInCSharp.Records;
using NUnit.Framework;

namespace ImmutableObjectInCSharp.Test;

[TestFixture]
public class TestTest 
{
    [Test]
    public void RecordEquality()
    {
        var immutable1 = new ImmutableRecord("Test");
        var immutable2 = new ImmutableRecord("Test");

        Assert.That(immutable1, Is.EqualTo(immutable2));
    }

    [Test]
    public void RecordReference()
    {
        var immutable1 = new ImmutableRecord("Test");
        var immutable2 = new ImmutableRecord("Test");

        Assert.That(immutable1, Is.Not.SameAs(immutable2));
    }

    [Test]
    public void ObjectEquality()
    {
        var immutable1 = new ImmutableObject("Test");
        var immutable2 = new ImmutableObject("Test");

        Assert.That(immutable1, Is.Not.EqualTo(immutable2));
    }

    [Test]
    public void Test2B()
    {
        var immutable1 = new ImmutableObject("Test");
        var immutable2 = new ImmutableObject("Test");

        Assert.That(immutable1, Is.Not.EqualTo(immutable2));
    }
}