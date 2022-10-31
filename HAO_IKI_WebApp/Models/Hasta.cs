using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HAO_IKI_WebApp.Models
{
    public class Hasta
    {
        public int HastaId { get; set; }
        public int Doktor { get; set; }
        public int? AileId { get; set; }
        public string AdSoyad { get; set; }
        public int? YasadigiSehir { get; set; }
        public bool? EslikEdenHastalik { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int? Yas { get; set; }
        public int? Boy { get; set; }
        public float? Kilo { get; set; }
        public int? VKI { get; set; }
        public bool? AnneBabaAkrabalik { get; set; }
        public string? AnneBabaAkrabalikDerece { get; set; }
        public bool? AnneanneDedeAkrabalik { get; set; }
        public bool? AileOykusu { get; set; }
        public string? HastaSonDurum { get; set; }
        public DateTime? HastaSonDurumOlumTarihi { get; set; }
        public long? Cinsiyet { get; set; }
        public string Cinsiyet_Str {get; set;}
        public int? TanininKoyulduguYil { get; set; }
        public int? TaniYasi { get; set; }
        public int? SemptomBaslamaYili { get; set; }
        public int? TaniGecikmeYili { get; set; }
        public string? AnjiyoodemTipi { get; set; }
        public string? CalismaDurumu { get; set; }
        public int? DogumYeri { get; set; }
        public bool? AiledeLarengealAtagaBagliOlum { get; set; }
        public string HastalikDiger { get; set; }
        public string MeslekDiger { get; set; }
        public string EgzersizDiger { get; set; }
    }
}
