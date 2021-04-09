namespace CampingRusevi.Common
{
    using Microsoft.AspNetCore.Http;
    using System.Threading.Tasks;
    using System.IO;

    public static class FormFileExtensions
    {
        public static async Task<byte[]> GetBytes(this IFormFile formFile)
        {
            using (var memoryStream = new MemoryStream())
            {
                await formFile.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
