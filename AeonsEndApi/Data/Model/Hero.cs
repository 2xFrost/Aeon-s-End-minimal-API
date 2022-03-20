namespace AeonsEndApi.Data.Model;

public class Hero
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string BackStory { get; set; }
    public string AbilityName { get; set; }
    public string AbilityDescription { get; set; }
    public string? Breach1 { get; set; }
    public string? Breach2 { get; set; }
    public string? Breach3 { get; set; }
    public string? Breach4 { get; set; }
    public int HandCount { get; set; }
    public int DeckCount { get; set; }
    public int SparkCount { get; set; }
    public int CrystalCount { get; set; }
    public int CrystalHandCount { get; set; }
    public int SparkHandCount { get; set; }
    [JsonIgnore]
    public GameVersion GameVersion { get; set; }
    public int VersionId { get; set; }
    public ICollection<Card> UniqueCards { get; set; }
}
