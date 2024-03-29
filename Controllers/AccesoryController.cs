using Final.Models;
using Final.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Final.ViewModels;

namespace Final.Controllers;

public class AccesoryController : Controller
{
    private readonly IAccesoryService _accesoryService;

    public AccesoryController(IAccesoryService accesoryService){
        _accesoryService = accesoryService;
    }

    public IActionResult Index(string? nameFilter)
    {
        AccesorySearchViewModel accesorySearchViewModel;
        if(!string.IsNullOrEmpty(nameFilter)){
            accesorySearchViewModel = _accesoryService.GetAll(nameFilter);
        }else{
            accesorySearchViewModel = _accesoryService.GetAll();
        }
        return View(accesorySearchViewModel);
    }
    // [Authorize(Roles = "admin, broker")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create([Bind("Id,Name,SerialNumber")]Accesory model)
    {
        if (ModelState.IsValid)
        {
            _accesoryService.Update(model);
            return RedirectToAction(nameof(Index));
        }

        return RedirectToAction("Index");
    }

    // [Authorize(Roles = "admin, broker")]
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var accesory = _accesoryService.GetById(id.Value);
        if (accesory == null)
        {
            return NotFound();
        }

        return View(accesory);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var accesory = _accesoryService.GetById(id);
        if (accesory != null)
        {
            _accesoryService.Delete(accesory);
        }
                    
        return RedirectToAction(nameof(Index));
    }
}