using Final.Models;
using Final.ViewModels;

namespace Final.Services;

public interface IMotoService
{
    MotoViewModel GetAll();
    void Update(MotoCreateViewModel obj);
    void Delete(Moto obj);
    Moto? GetById(int id);
    MotoViewModel GetAll(string nameFilter);
    bool ExistMotoWithBrandAndName(string brand, string model);
}