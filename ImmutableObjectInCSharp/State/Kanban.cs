namespace ImmutableObjectInCSharp.State;

public class Kanban
{
    public Ticket Move(Ticket state, TicketEvent @event) =>

        @event switch
        {
            TicketEvent.Create(var description)
                => state is Ticket.Empty
                    ? new Ticket.Open(description)
                    : state,
            TicketEvent.Assign(var userName)
                => state is Ticket.Open(var description)
                    ? new Ticket.InProgress(description, userName)
                    : state,
            TicketEvent.ReAssign(var userName)
                => state is Ticket.InProgress inProgress
                    ? inProgress with { UserName = userName } 
                    : state,
            TicketEvent.Finish(var resolution)
                => state is Ticket.InProgress(var description, var userName)
                    ? new Ticket.Done(description, userName, resolution)
                    : state,
            _ => throw new ArgumentOutOfRangeException(nameof(@event), @event, null)
        };
}