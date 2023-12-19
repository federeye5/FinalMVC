using Final.Models;

namespace Final.Services;

public interface IInventoryService
{
    List<Inventory> GetAll();
    List<Inventory> GetAll(string nameFiler);
    void Update(Inventory obj);
    void Delete(Inventory obj);
    Inventory? GetById(int id);
    Inventory? GetInventoryByAgencyIdAndMotoId(int agencyId, int motoId);

}