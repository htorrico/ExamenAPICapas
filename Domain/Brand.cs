using System.Text.Json.Serialization;

namespace Domain
{
    public class Brand
    {
        public int BrandID { get; set; }
        public string Name { get; set; }

        //FK
        public int? CountryID { get; set; }

        [JsonIgnore]
        public Country? Country { get; set; }

    }
}
