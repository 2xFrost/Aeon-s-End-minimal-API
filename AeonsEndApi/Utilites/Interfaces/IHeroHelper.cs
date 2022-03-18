namespace AeonsEndApi.Utilites.Interfaces;

public interface IHeroHelper
{
    Task GetAllHeroes();
    Task GetHeroById(int id);
}