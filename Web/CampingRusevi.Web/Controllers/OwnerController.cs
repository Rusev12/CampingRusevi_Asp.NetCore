namespace CampingRusevi.Web.Controllers
{
    using CampingRusevi.Data.Common.Repositories;
    using CampingRusevi.Data.Models;
    using CampingRusevi.Services.Data.OwnerServices;
    using CampingRusevi.Web.ViewModels.Owner;
    using Microsoft.AspNetCore.Mvc;

    public class OwnerController : Controller
    {
        private readonly IDeletableEntityRepository<Owner> _repository;
        private readonly IOwnerService _ownerService;

        public OwnerController(IDeletableEntityRepository<Owner> repository , IOwnerService ownerService)
        {
            this._repository = repository;
            this._ownerService = ownerService;
        }

        public IActionResult Index()
        {
            var allModels = this._ownerService.GetAll<OwnerViewModel>();
            var model = new OwnerListViewModel() { Owners = allModels };
            return this.View(model);
        }

        public IActionResult AddNewOwner()
        {
            this._repository.AddAsync(new Owner() { FullName = "Slavi", ShortDescription = "Test" });
            this._repository.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
