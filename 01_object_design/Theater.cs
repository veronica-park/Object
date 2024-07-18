namespace ConsoleApp3._01_object_design;
/// <summary>
/// 극장
/// </summary>
public class Theater
{
    private TicketSeller TicketSeller { get; set; }

    public Theater(TicketSeller ticketSeller)
    {
        TicketSeller = ticketSeller;
    }

    public void Enter(Audience audience)
    {
        TicketSeller.SellTo(audience);
    }
}