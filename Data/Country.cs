using System.ComponentModel.DataAnnotations;

namespace hotellisting.api.Data
{
    public class Country
    {
        [Key]
        int CountryId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public IList<Hotel> Hotels { get; set; } = [];
    }
}
