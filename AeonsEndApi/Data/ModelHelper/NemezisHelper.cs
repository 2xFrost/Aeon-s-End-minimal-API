namespace AeonsEndApi.Data.ModelHelper;

public class NemezisHelper : INemezisHelper
{
    public async Task GetAllNemeses()
    {
        using (var db = new DataContext())
        {
            await db.Nemeses.ToListAsync();
        }
    }

    public async Task GetNemezisById(int id)
    {
        using (var db = new DataContext())
        {
            await db.Nemeses.FindAsync(id);
        }
    }
}
