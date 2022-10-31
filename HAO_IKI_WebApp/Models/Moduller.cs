namespace HAO_IKI_WebApp.Models
{
    public class Moduller
    {
        public long Id { get; set; }
        public string Adi { get; set; }
        public long? UstModul { get; set; }
        public bool AcilabilirMenu { get; set; }
        public string? Icon { get; set; }
        public string? Adres { get; set; }
        public string? Parametre { get; set; }
        public int Sira { get; set; }
        public DateTime? Created { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
