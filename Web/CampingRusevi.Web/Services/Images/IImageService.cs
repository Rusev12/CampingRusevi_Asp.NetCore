namespace CampingRusevi.Web.Services.ImageService
{
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;

    using CampingRusevi.Data.Models;

    public interface IImageService
    {
        Task Process(IEnumerable<ImageInputModel> images);

        Task<Stream> GetThumbnail(string id);

        Task<Stream> GetFullscreen(string id);

        Task<List<string>> GetAllImages();

    }
}
