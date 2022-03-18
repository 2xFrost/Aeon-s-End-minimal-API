using Newtonsoft.Json;

namespace AeonsEndApi.Data.SeederData;

public static class DataSeed
{
    public static void SeedData()
    {
        string path = "Data\\SeederData\\Static";

        SeedCardTypes(path);
        SeedVersions(path);
        //SeedNemeses(path);
        //SeedHeros(path); 
        //SeedCards(path);                          
    }
    private static void SeedCardTypes(string path)
    {
        using (var db = new DataContext())
        {
            if (!db.CardTypes.Any())
            {
                List<CardType> types = Deserialize<CardType>("CardTypeDataTest.json",path);
                db.CardTypes.AddRange(types);
                db.SaveChanges();
            }
        }
    }
    private static void SeedVersions(string path)
    {
        using (var db = new DataContext())
        {
            if (!db.GameVersions.Any())
            {
                List<GameVersion> versions = Deserialize<GameVersion>("GameVersionDataTest.json", path);
                db.GameVersions.AddRange(versions);
                db.SaveChanges();
            }
        }
    }
    private static void SeedNemeses(string path)
    {
        using (var db = new DataContext())
        {
            if (!db.Nemeses.Any())
            {
                List<Nemezis> nemesesList = Deserialize<Nemezis>("NemezisData.json", path);
                db.Nemeses.AddRange(nemesesList);
                db.SaveChanges();
            }
        }
    }
    private static void SeedHeros(string path)
    {
        using (var db = new DataContext())
        {
            if (!db.Heroes.Any())
            {
                List<Hero> heroList = Deserialize<Hero>("HeroData.json", path);
                db.Heroes.AddRange(heroList);
                db.SaveChanges();
            }
        }
    }
    private static void SeedCards(string path)
    {
        using (var db = new DataContext())
        {
            if (db.Cards.Count() == 0)
            {
                List<Card> cardList = Deserialize<Card>("TestData.json", path);
                db.Cards.AddRange(cardList);
                db.SaveChanges();
                Console.WriteLine("Tabel seeded properly");
            }
        }
    }
    private static List<TEntity> Deserialize<TEntity>(string fileName, string path)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string fullPath = Path.Combine(currentDirectory, path, fileName);
        var result = new List<TEntity>();
        using (StreamReader reader = new StreamReader(fullPath))
        {
            string json = reader.ReadToEnd();
            result = JsonConvert.DeserializeObject<List<TEntity>>(json);
        }

        return result;
    }
}
