namespace AeonsEndApi.Utilites;

public static class Services
{
    public static void BuilderServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddScoped<ICardHelper, CardHelper>();
        builder.Services.AddScoped<IGameVersionHelper, GameVersionHelper>();
        builder.Services.AddScoped<IHeroHelper, HeroHelper>();
        builder.Services.AddScoped<INemezisHelper, NemezisHelper>();
    }
}
