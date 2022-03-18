using AeonsEndApi.Utilites.Interfaces;

namespace Data.ModelHelper;

public class CardHelper : ICardHelper
{

    public List<Card> GetAllCards()
    {
        using (var db = new DataContext())
        {
            return db.Cards.ToList();
        }
    }

    public Card GetCardById(int id)
    {
        using (var db = new DataContext())
        { 
            return db.Cards.Find(id);
        }
    }
}
