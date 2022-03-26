namespace AeonsEndApi.Utilites.Endpoints;

public static class EndpointHub
{
    public static WebApplication EndpointsHub(this WebApplication app)
    {
        #region
        app.MapGet("/api/cards", EndpointHub.GetAllCards);
        //app.MapGet("/api/cards/{id}", EndpointHub.GetCardById);
        app.MapGet("api/cards/{name}", EndpointHub.GetCardByName);
        #endregion
        app.MapGet("/api/heroes", EndpointHub.GetAllHeroes);
        app.MapGet("/api/heroes/{id}", EndpointHub.GetHeroById);

        app.MapGet("api/nemeses", EndpointHub.GetAllNemeses);
        app.MapGet("api/nemeses/{id}", EndpointHub.GetNemezisById);

        app.MapGet("api/Games", EndpointHub.GetAllGames);
        app.MapGet("api/Games/{id}", EndpointHub.GetGamesById);

        return app;
    }

    private static IResult GetAllCards(ICardHelper cardHelper)
    {
        return Results.Ok(cardHelper.GetAllCards());
    }
    private static IResult GetCardById(ICardHelper cardHelper, int id)
    {
        var card = cardHelper.GetCardById(id);
        if (card == null) return Results.NotFound();

        return Results.Ok(card);
    }

    private static IResult GetCardByName(ICardHelper cardHelper, string name)
    {
        var card = cardHelper.GetCardByName(name);
        if (card == null) return Results.NotFound();

        return Results.Ok(card);
    }


    private static IResult GetAllHeroes(IHeroHelper heroHelper)
    {
        return Results.Ok(heroHelper.GetAllHeroes());
    }
    private static IResult GetHeroById(IHeroHelper heroHelper, int id)
    {
        var hero = heroHelper.GetHeroById(id);
        if (hero == null) return Results.NotFound();

        return Results.Ok(hero);
    }

    private static IResult GetAllNemeses(INemezisHelper nemezisHelper)
    {
        return Results.Ok(nemezisHelper.GetAllNemeses());
    }
    private static IResult GetNemezisById(INemezisHelper nemezisHelper, int id)
    {
        var nemezis = nemezisHelper.GetNemezisById(id);
        if (nemezis == null) return Results.NotFound();

        return Results.Ok(nemezis);
    }

    private static IResult GetAllGames(IGameVersionHelper versionHelper)
    {
        return Results.Ok(versionHelper.GetAllGames());
    }
    private static IResult GetGamesById(IGameVersionHelper versionHelper, int id)
    {
        var game = versionHelper.GetGameById(id);
        if (game == null) return Results.NotFound();

        return Results.Ok(game);
    }

}
