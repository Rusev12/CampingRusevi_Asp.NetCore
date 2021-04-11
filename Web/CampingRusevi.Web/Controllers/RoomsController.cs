namespace CampingRusevi.Web.Controllers
{
    using CampingRusevi.Common;
    using CampingRusevi.Data;
    using CampingRusevi.Data.Common.Repositories;
    using CampingRusevi.Data.Models;
    using CampingRusevi.Web.ViewModels.Rooms;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using System.IO;
    using System.Threading.Tasks;

    public class RoomsController : Controller
    {
        private readonly IDeletableEntityRepository<Apartment> _repository;

        public RoomsController(IDeletableEntityRepository<Apartment> repository)
        {
            this._repository = repository;
        }

        public IActionResult Index()
        {

            return this.View();
        }

        public async Task<IActionResult> AllApartments()
        {
            return View();
        }

        public async Task<IActionResult> Create(RoomVwModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(model);
            }

            var apartment = new Apartment()
            {
                Image = await FormFileExtensions.GetBytes(model.MainImagePath),
                Description = model.RoomDescription,
            };

            await this._repository.AddAsync(apartment);
            await this._repository.SaveChangesAsync();

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
