namespace AeonsEndApi.Data.Model;

public class Card
{
    public int Id { get; set; }
    public string CardName { get; set; }
    public string Description { get; set; }
    public int Cost { get; set; }
    public bool IsBasic { get; set; }
    public int? AmmountInHand { get; set; }
    public int? MarketAmmount { get; set; }


    //navigation
    [JsonIgnore]
    public CardType Type { get; set; }
    public int TypeId { get; set; }
    [JsonIgnore]
    public GameVersion GameVersion { get; set; }
    public int GameVersionId { get; set; }
    [JsonIgnore]
    public Hero Hero { get; set; }
    public int? HeroId { get; set; }
}