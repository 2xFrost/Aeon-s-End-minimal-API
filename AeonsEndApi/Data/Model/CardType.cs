namespace Data.Model;

public class CardType
{
    public int Id { get; set; }
    public string Type { get; set; }

    public ICollection<Card> Cards { get; set;}
    
}
