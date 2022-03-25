namespace AeonsEndApi.Data.Dto;

public class CardDto
{
    public string CardName { get; set; }
    public string CardType { get; set; }
    public string Description { get; set; }
    public int Cost { get; set; }
    public int? AmmountInHand { get; set; }
    public int? MarketAmmount { get; set; }
}
