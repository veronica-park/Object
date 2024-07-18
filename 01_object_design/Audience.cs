namespace ConsoleApp3._01_object_design;
/// <summary>
/// 관람객
/// </summary>
public class Audience
{
    private Bag Bag { get; set; }

    public Audience(Bag bag)
    {
        Bag = bag;
    }

    // public Bag GetBag()
    // {
    //     return Bag;
    // }

    public long Buy(Ticket ticket)
    {
        if (Bag.HasInvitation())
        {
            Bag.SetTicket(ticket);
            return 0;
        }
        else
        {
            Bag.SetTicket(ticket);
            Bag.MinusAmount(ticket.GetFee());
            return ticket.GetFee();
        }
    }
}