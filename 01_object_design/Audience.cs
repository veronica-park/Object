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

    public Bag GetBag()
    {
        return Bag;
    }
}