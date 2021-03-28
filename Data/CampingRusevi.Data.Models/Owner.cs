namespace CampingRusevi.Data.Models
{
    using CampingRusevi.Data.Common.Models;

    public class Owner : BaseDeletableModel<int>
    {
        public string FullName { get; set; }

        public string ShortDescription { get; set; }
    }
}
