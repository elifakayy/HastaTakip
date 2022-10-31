namespace HAO_IKI_WebApp.Models
{
    public class Kompleman
    {
        public int HastaId { get; set; }
        public float C1InhibitorDuzey { get; set; }
        public long? C1InhibitorBirim { get; set; }
        public float C1InhibitorFonksiyonuDuzey { get; set; }
        public long? C1InhibitorFonksiyonuBirim { get; set; }
        public float C4Duzey { get; set; }
        public long? C4Birim { get; set; }
        public float C3Duzey { get; set; }
        public long? C3Birim { get; set; }
        public float? C1qDuzey { get; set; }
        public long? C1qBirim { get; set; }
        public bool Antic1InhibitorOtoantikoru { get; set; }
        public DateTime Tarih { get; set; }
    }
}
