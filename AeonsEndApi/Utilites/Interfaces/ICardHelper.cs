namespace AeonsEndApi.Utilites.Interfaces;

public interface ICardHelper
{
    List<Card> GetAllCards();
    Card GetCardById(int id);
}