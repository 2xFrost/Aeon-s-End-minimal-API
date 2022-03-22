using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;


namespace AeonsEndApi.Data.SeederData;

public static class CheckDB
{
    public static void DatabaseCheck(this WebApplication app)
    {

        using(var db = new DataContext())
        {
            db.Database.EnsureDeleted();
        }

        bool existCheck = dbExistsCheck();

        if (!existCheck)
        {
            dbCreation();
            DataSeed.SeedData();
        };
    }

    private static void dbCreation()
    {
        using (var db = new DataContext())
        {
            db.Database.Migrate();
        }
    }
    private static bool dbExistsCheck()
    {
        using (var db = new DataContext())
        {
            return db.Database.GetService<IRelationalDatabaseCreator>().Exists();
        }
    }
}

