using ImmutableObjectInCSharp.State;
using NUnit.Framework;

namespace ImmutableObjectInCSharp.Test;

[TestFixture]
public class KanbanTest
{
    [Test]
    public void KanbanCreate()
    {
        var kanban = new Kanban();

        var newState = kanban.Move(new Ticket.Empty(), new TicketEvent.Create("Test"));

        Assert.That(newState, Is.TypeOf<Ticket.Open>());
    }

    [Test]
    public void KanbanAssign()
    {
        var kanban = new Kanban();

        var newState = kanban.Move(new Ticket.Open("Test"), new TicketEvent.Assign("Dennis")) as Ticket.InProgress;

        Assert.Multiple(() =>
        {
            Assert.That(newState.Description, Is.EqualTo("Test"));
            Assert.That(newState.UserName, Is.EqualTo("Dennis"));
        });
    }

    [Test]
    public void KanbanReAssign()
    {
        var kanban = new Kanban();

        var newState = kanban.Move(new Ticket.InProgress("Test", "Dennis"), new TicketEvent.Assign("Herman")) as Ticket.InProgress;

        Assert.Multiple(() =>
        {
            Assert.That(newState.Description, Is.EqualTo("Test"));
            Assert.That(newState.UserName, Is.EqualTo("Herman"));
        });
    }

    [Test]
    public void KanbanFinish()
    {
        var kanban = new Kanban();

        var newState = kanban.Move(new Ticket.InProgress("Test", "Dennis"), new TicketEvent.Finish("Fixed")) as Ticket.Done;

        Assert.Multiple(() =>
        {
            Assert.That(newState.Description, Is.EqualTo("Test"));
            Assert.That(newState.UserName, Is.EqualTo("Dennis"));
            Assert.That(newState.Resolution, Is.EqualTo("Fixed"));
        });
    }
}