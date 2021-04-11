namespace CampingRusevi.Web.ViewModels.Images
{
    using Microsoft.AspNetCore.Http;
    using System.IO;

    public class ImageInputModel
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public IFormFile Content { get; set; }
    }
}
