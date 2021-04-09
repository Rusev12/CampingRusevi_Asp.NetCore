namespace CampingRusevi.Web.ViewModels.Rooms
{
    using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;

    public class RoomVwModel
    {
        public string RoomDescription { get; set; }

        public IFormFile MainImagePath { get; set; }

        public IEnumerable<IFormFile> DetailsImagesPaths { get; set; }
    }
}
