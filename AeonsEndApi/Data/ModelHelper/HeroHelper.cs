namespace AeonsEndApi.Data.ModelHelper;

public class HeroHelper : IHeroHelper
{
    public async Task GetAllHeroes()
    {
        using (var db = new DataContext())
        {
            await db.Heroes.ToListAsync();
        }
    }

    public async Task GetHeroById(int id)
    {
        using (var db = new DataContext())
        {
            await db.Heroes.FindAsync(id);
        }
    }
}
