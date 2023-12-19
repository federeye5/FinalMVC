using Final.ViewModels;
using Final.Models;
namespace Final.Services;

public interface IAccesoryService
{
    AccesorySearchViewModel GetAll();
    void Update(Accesory obj);
    void Delete(Accesory obj);
    Accesory? GetById(int id);
    AccesorySearchViewModel GetAll(string nameFilter);
}