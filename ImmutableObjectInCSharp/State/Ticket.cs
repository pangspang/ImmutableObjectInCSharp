namespace ImmutableObjectInCSharp.State;

public abstract record Ticket
{
    public record Empty : Ticket;
    
    public record Open(
        string Description
        ) : Ticket;

    public record InProgress(
        string Description,
        string UserName
        ) : Ticket;

    public record Done(
        string Description,
        string UserName,
        string Resolution
        ) : Ticket;
}