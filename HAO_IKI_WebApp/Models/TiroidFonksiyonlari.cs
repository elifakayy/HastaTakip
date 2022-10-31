namespace HAO_IKI_WebApp.Models
{
    public class TiroidFonksiyonlari
    {
        public int HastaId { get; set; }
        public float TSHDuzey { get; set; }
        public float FT4Duzey { get; set; }
        public bool ANA { get; set; }
        public bool LKM { get; set; }
        public bool AntiTPO { get; set; }
        public bool AntiTiroglobulin { get; set; }
        public bool AntiTransglutaminaz { get; set; }
        public bool AntiGliadin { get; set; }
        public bool AntiEndomisyum { get; set; }
        public DateTime Tarih { get; set; }
        public long? TSHBirim { get; set; }
        public long? FT4Birim { get; set; }
        public float TSHReferansBaslangic { get; set; }
        public float TSHReferansBitis { get; set; }
        public float FT4ReferansBaslangic { get; set; }
        public float FT4ReferansBitis { get; set; }

    }
}
