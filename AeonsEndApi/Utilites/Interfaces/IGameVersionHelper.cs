namespace AeonsEndApi.Utilites.Interfaces;

public interface IGameVersionHelper
{
    List<GameVersion> GetAllGames();
    GameVersion GetGameById(int id);
}