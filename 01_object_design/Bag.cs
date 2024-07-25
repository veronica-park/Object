namespace ConsoleApp3._01_object_design;
/// <summary>
/// 관람객이 소지품을 보관 할 가방
/// </summary>
public class Bag
{
    /// <summary>
    /// 티켓 구매 할 현금
    /// </summary>
    private long Amount { get; set; }
    private Invitation? Invitation { get; set; }
    private Ticket? Ticket { get; set; }

    public Bag(long amount) : this(amount, null)
    {
        
    }

    public Bag(long amount, Invitation? invitation = null) 
    {
        Amount = amount;
        Invitation = invitation;
    }

    public long Hold(Ticket ticket)
    {
        if (HasInvitation())
        {
            SetTicket(ticket);
            return 0;
        }
        else
        {
            SetTicket(ticket);
            MinusAmount(ticket.GetFee());
            return ticket.GetFee();
        }
    }
    
    private bool HasInvitation()
    {
        return Invitation is not null;
    }

    public bool HasTicket()
    {
        return Ticket is not null;
    }

    private void SetTicket(Ticket ticket)
    {
        Ticket = ticket;
    }

    private void MinusAmount(long amount)
    {
        Amount -= amount;
    }

    private void PlusAmount(long amount)
    {
        Amount += amount;
    }
}