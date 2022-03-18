namespace Data.Model;

public class Hero
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string BackStory { get; set; }
    public string AbilityName { get; set; }
    public string AbilityDescription { get; set; }

    public GameVersion GameVersion { get; set; }
    public int VersionId { get; set; }

    public ICollection<Card> Cards { get; set; }


    //gameversion
    //uniquecard
}
