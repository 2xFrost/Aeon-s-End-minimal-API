namespace Data.ModelHelper;

public class GameVersionHelper : IGameVersionHelper
{
    public List<GameVersion> GetAllGames()
    {
        using (var db = new DataContext())
        {
           return db.GameVersions.ToList();
        }
    }

    public GameVersion GetGameById(int Id)
    {
        using (var db = new DataContext())
        {
            return db.GameVersions.Find(Id);
        }
    }
}
