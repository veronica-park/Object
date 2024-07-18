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

    private List<Ticket> _tickets = new List<Ticket>();

    public TicketOffice(long amount, Ticket ticket)
    {
        Amount = amount;
        _tickets.Add(ticket);
    }

    public Ticket GetTicket()
    {
        var ticket = _tickets.First();
        _tickets.RemoveAt(0);
        return ticket;
    }

    public void MinusAmount(long amount)
    {
        Amount -= amount;
    }

    public void PlusAmount(long amount)
    {
        Amount += amount;
    }
}