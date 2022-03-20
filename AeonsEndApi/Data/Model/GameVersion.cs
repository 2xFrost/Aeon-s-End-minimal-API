namespace AeonsEndApi.Data.Model;

public class GameVersion
{

    public int GameVersionId { get; set; }
    public string Version { get; set; }
    public string GameType { get; set; }

    public ICollection<Card> Cards { get; set; }
    public ICollection<Nemezis> Nemeses { get; set; }

    public ICollection<Hero> Heroes { get; set; }

    //nemezis
    //hero
    //card
}
