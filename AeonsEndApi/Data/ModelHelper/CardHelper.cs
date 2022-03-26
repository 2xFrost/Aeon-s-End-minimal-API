using AeonsEndApi.Data.Dto;

namespace AeonsEndApi.Data.ModelHelper;

public class CardHelper : ICardHelper
{

    public List<CardDto> GetAllCards()
    {
        using (var db = new DataContext())
        {
            var list = (from card in db.Cards
                        join type in db.CardTypes
                        on card.TypeId equals type.Id
                        select new CardDto {CardName = card.CardName,
                                            CardType = type.Name,
                                            Cost = card.Cost,
                                            AmmountInHand = card.AmmountInHand,
                                            MarketAmmount = card.MarketAmmount,
                                            Description = card.Description}).ToList();

            return list;
        }
    }

    public CardDto GetCardById(int id)
    {
        var searchedCard = new Card();

        SearchCardId(id, ref searchedCard);

        using (var db = new DataContext())
        {
            var cardDto = (from card in db.Cards
                        join type in db.CardTypes
                        on card.TypeId equals type.Id
                        where card.CardName == searchedCard.CardName
                        select new CardDto
                        {
                            CardName = card.CardName,
                            CardType = type.Name,
                            Cost = card.Cost,
                            AmmountInHand = card.AmmountInHand,
                            MarketAmmount = card.MarketAmmount,
                            Description = card.Description
                        }).SingleOrDefault();            

            return cardDto;
        }
    }
    public CardDto GetCardByName(string name)
    {
        using (var db = new DataContext())
        {
            var cardDto = (from card in db.Cards
                          join type in db.CardTypes
                          on card.TypeId equals type.Id
                          where card.CardName == name
                          select new CardDto
                          {
                              CardName = card.CardName,
                              CardType = type.Name,
                              Cost = card.Cost,
                              AmmountInHand = card.AmmountInHand,
                              MarketAmmount = card.MarketAmmount,
                              Description = card.Description
                          }).SingleOrDefault();

            return cardDto;
        }
    }

    public List<CardDto> GetHeroUniqueCards(string heroName)
    {
        int id = 0;

        CheckHeroId(ref id, heroName);

        using (var db = new DataContext())
        {
            var cardDto = (from card in db.Cards
                           join type in db.CardTypes
                           on card.TypeId equals type.Id
                           join hero in db.Heroes
                           on card.HeroId equals hero.Id
                           where card.HeroId == id
                           select new CardDto
                           {
                               CardName = card.CardName,
                               CardType = type.Name,
                               Cost = card.Cost,
                               AmmountInHand = card.AmmountInHand,
                               MarketAmmount = card.MarketAmmount,
                               Description = card.Description
                           }).ToList();
            return cardDto;
        }
    }
    private static void SearchCardId(int id, ref Card card)
    {
        using (var db = new DataContext())
        {
            card = db.Cards.Find(id);
        }
    }
    private static void CheckHeroId(ref int id, string heroName)
    {
        using(var db = new DataContext()) 
        {
            var hero = db.Heroes.Where(h => h.Name == heroName).FirstOrDefault();
            if (hero != null) id = hero.Id;            
        }
    }
}

