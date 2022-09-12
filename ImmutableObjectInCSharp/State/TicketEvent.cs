namespace ImmutableObjectInCSharp.State;

public abstract record TicketEvent
{
    public record Create(string Description) : TicketEvent;
    
    public record Assign(string UserName) : TicketEvent;

    public record ReAssign(string UserName) : TicketEvent;

    public record Finish(string Resolution) : TicketEvent;
}