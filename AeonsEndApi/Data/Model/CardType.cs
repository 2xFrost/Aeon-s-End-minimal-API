namespace AeonsEndApi.Data.Model;

public class CardType
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Card> Cards { get; set; }

}
