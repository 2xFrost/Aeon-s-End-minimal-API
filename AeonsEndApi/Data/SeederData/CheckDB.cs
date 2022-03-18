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
        bool connectionCheck = dbConnectionCheck();

        if (!existCheck && !connectionCheck)
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
    private static bool dbConnectionCheck()
    {
        using (var db = new DataContext())
        {
            return db.Database.CanConnect();
        }
    }
}

