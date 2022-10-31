using System.ComponentModel.DataAnnotations;

namespace HAO_IKI_WebApp.Models
{
    public class Kullanicilar
    {
        public int KullaniciId { get; set; }
        public int KullaniciTipi { get; set; }
        [Required]
        public string Sifre { get; set; }
        public int? MerkezId { get; set; }
        [StringLength(100, MinimumLength = 100)]
        
        public string KullaniciAdi { get; set; }
        public byte? SifreHash { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string?  DiplomaNo { get; set; }
        [Display(Name = "Kullanici Adı")]
        public string Email { get; set; }
        public int DurumId { get; set; }
        public DateTime? SilinmeTarihi { get; set; }
        public byte? SifreSalt { get; set; }
        public DateTime? Created { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }

    }
}
