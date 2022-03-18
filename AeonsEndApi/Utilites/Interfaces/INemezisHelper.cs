namespace AeonsEndApi.Utilites.Interfaces;

public interface INemezisHelper
{
    Task GetAllNemeses();
    Task GetNemezisById(int id);
}