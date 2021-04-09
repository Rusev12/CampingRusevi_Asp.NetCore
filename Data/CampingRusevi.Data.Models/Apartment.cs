namespace CampingRusevi.Data.Models
{
    using CampingRusevi.Data.Common.Models;

    public class Apartment : BaseDeletableModel<int>
    {
        public byte[] Image { get; set; }

        public string Description { get; set; }
    }
}
