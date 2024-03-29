using Final.Data;
using Final.Models;
using Microsoft.EntityFrameworkCore;

namespace Final.Services;

public class InventoryServiceImpl : IInventoryService
{
    private readonly MotoContext _context;
    
    public InventoryServiceImpl(MotoContext context){
        _context = context;
    }

    public void Delete(Inventory obj)
    {
        _context.Inventory.Remove(obj);
        _context.SaveChanges();
    }

    public List<Inventory> GetAll()
    {
        List<Inventory> inventorys = new List<Inventory>();
        inventorys = _context.Inventory.ToList();
        return inventorys;
    }

    public List<Inventory> GetAll(string nameFiler)
    {
        throw new NotImplementedException();
    }

    public Inventory? GetById(int id)
    {
       return _context.Inventory.Include(x=> x.Moto)
                .FirstOrDefault(m => m.Id == id);
    }

    public void Update(Inventory obj)
    {
        _context.Update(obj);
        _context.SaveChanges();
    }

    public Inventory? GetInventoryByAgencyIdAndMotoId(int agencyId, int motoId)
    {
        var inventory = _context.Inventory.Where(i => i.AgencyId == agencyId && i.MotoId == motoId).FirstOrDefault();
        return inventory;
    }
}