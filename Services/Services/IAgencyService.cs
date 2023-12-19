using Final.Models;
using Final.ViewModels;

namespace Final.Services;

public interface IAgencyService
{
    AgencyViewModel GetAll();
    AgencyViewModel GetAll(string nameFilter);
    void Update(Agency obj);
    void Delete(Agency obj);
    Agency? GetById(int id);
    AgencyViewModel? GetAgencyWithInventoryById(int id);


}