using AeonsEndApi.Data.Dto;

namespace AeonsEndApi.Utilites.Interfaces;

public interface ICardHelper
{
    List<CardDto> GetAllCards();
    CardDto GetCardById(int id);
    CardDto GetCardByName(string name);
}