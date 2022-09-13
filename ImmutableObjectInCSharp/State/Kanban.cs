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
            TicketEvent.Assign assign
                => Assign(state, assign),
            TicketEvent.Finish(var resolution)
                => state is Ticket.InProgress(var description, var userName)
                    ? new Ticket.Done(description, userName, resolution)
                    : state,
            _ => throw new ArgumentOutOfRangeException(nameof(@event), @event, null)
        };

    public Ticket Assign(Ticket state, TicketEvent.Assign assignEvent) =>
        state switch
        {
            Ticket.Open(var description) =>
                new Ticket.InProgress(description, assignEvent.UserName),
            Ticket.InProgress inProgress =>
                inProgress with { UserName = assignEvent.UserName },
            _ => throw new ArgumentOutOfRangeException(nameof(state), state, null)
        };

}