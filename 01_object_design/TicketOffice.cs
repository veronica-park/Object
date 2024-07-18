namespace ConsoleApp3._01_object_design;
/// <summary>
/// 매표소
/// </summary>
public class TicketOffice
{
    /// <summary>
    /// 판매 금액??
    /// </summary>
    private long Amount { get; set; }

    private List<Ticket> Tickets = new List<Ticket>();

    public TicketOffice(long amount, Ticket ticket)
    {
        Amount = amount;
        Tickets.Add(ticket);
    }

    public Ticket GetTicket()
    {
        var ticket = Tickets.;
        return Tickets.
    }
}