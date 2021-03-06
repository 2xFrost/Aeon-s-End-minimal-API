namespace AeonsEndApi.Data.Model;

public class Nemezis
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string BackStory { get; set; }
    public string GameStart { get; set; }
    public string Release { get; set; }

    [JsonIgnore]
    public GameVersion GameVersion { get; set; }
    public int VersionId { get; set; }
}
