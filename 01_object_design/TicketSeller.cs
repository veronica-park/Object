namespace ConsoleApp3._01_object_design;
/// <summary>
/// 판매원 (매표소에서 티켓 교환 및 판매)
/// </summary>
public class TicketSeller
{
    private TicketOffice TicketOffice { get; set; }

    public TicketSeller(TicketOffice ticketOffice)
    {
        TicketOffice = ticketOffice;
    }

    // 외부에서 ticket office 접근 불가
    // public TicketOffice GetTicketOffice()
    // {
    //     return TicketOffice;
    // }

    public void SellTo(Audience audience)
    {
        if (audience.GetBag().HasInvitation())
        {
            var ticket = TicketOffice.GetTicket();
            audience.GetBag().SetTicket(ticket);
        }
        else
        {
            var ticket = TicketOffice.GetTicket();
            audience.GetBag().MinusAmount(ticket.GetFee());
            TicketOffice.PlusAmount(ticket.GetFee());
            audience.GetBag().SetTicket(ticket);
        }
    }
}