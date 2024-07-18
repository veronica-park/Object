namespace ConsoleApp3._01_object_design;
/// <summary>
/// 공연 관람자는 티켓 소유 해야 함
/// </summary>
public class Ticket
{
    /// <summary>
    /// 티켓 금액
    /// </summary>
    private long Fee { get; set; }

    public long GetFee()
    {
        return Fee;
    }
}